using InteligenciaClimatica.Models;
using MySqlConnector;
using System;
using System.Data.SQLite;

namespace InteligenciaClimatica.Services
{
    public class DatabaseService
    {
        // ── Prueba de Conexión Local (SQLite) ──
        public string ProbarConexionSQLite(string rutaArchivo)
        {
            try
            {
                // En System.Data.SQLite armamos la cadena directamente
                string cadenaConexion = $"Data Source={rutaArchivo};Version=3;";

                // Si el archivo no existe, la librería lo creará automáticamente al intentar conectar
                using var conexion = new SQLiteConnection(cadenaConexion);
                conexion.Open();

                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // ── Prueba de Conexión Remota (MariaDB) ──
        public string ProbarConexionMariaDB(string servidor, string puerto, string bd, string usuario, string password)
        {
            try
            {
                var builder = new MySqlConnectionStringBuilder
                {
                    Server = servidor,
                    Port = uint.Parse(puerto),
                    Database = bd,
                    UserID = usuario,
                    Password = password,
                    ConnectionTimeout = 5
                };

                using var conexion = new MySqlConnection(builder.ConnectionString);
                conexion.Open();
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        // ── Guardar Alerta en Servidor (MariaDB) ──
        public void GuardarAlertaMariaDB(string servidor, string puerto, string bd, string usuario, string password,
                                         string municipio, string estado, double tempActual, double tempHistorica, double anomalia)
        {
            var builder = new MySqlConnectionStringBuilder
            {
                Server = servidor,
                Port = uint.Parse(puerto),
                Database = bd,
                UserID = usuario,
                Password = password
            };

            using var conexion = new MySqlConnection(builder.ConnectionString);
            conexion.Open();

            // 1. Asegurarnos de que la tabla exista (Se ejecuta rápido y no sobreescribe si ya existe)
            string queryCreacion = @"
        CREATE TABLE IF NOT EXISTS AlertasClimaticas (
            Id INT AUTO_INCREMENT PRIMARY KEY,
            FechaRegistro DATETIME NOT NULL,
            Municipio VARCHAR(150) NOT NULL,
            Estado VARCHAR(100) NOT NULL,
            TemperaturaActual DOUBLE NOT NULL,
            PromedioHistorico DOUBLE NOT NULL,
            Anomalia DOUBLE NOT NULL
        );";

            using var cmdCreacion = new MySqlCommand(queryCreacion, conexion);
            cmdCreacion.ExecuteNonQuery();

            // 2. Insertar el nuevo registro de alerta
            string queryInsert = @"
        INSERT INTO AlertasClimaticas 
        (FechaRegistro, Municipio, Estado, TemperaturaActual, PromedioHistorico, Anomalia) 
        VALUES (@fecha, @mun, @est, @actual, @hist, @anom);";

            using var cmdInsert = new MySqlCommand(queryInsert, conexion);

            // Pasamos los valores como parámetros seguros para evitar inyecciones SQL
            cmdInsert.Parameters.AddWithValue("@fecha", DateTime.Now);
            cmdInsert.Parameters.AddWithValue("@mun", municipio);
            cmdInsert.Parameters.AddWithValue("@est", estado);
            cmdInsert.Parameters.AddWithValue("@actual", tempActual);
            cmdInsert.Parameters.AddWithValue("@hist", tempHistorica);
            cmdInsert.Parameters.AddWithValue("@anom", anomalia);

            cmdInsert.ExecuteNonQuery();
        }

        public void GuardarRankingMariaDB(string host, string puerto, string bd, string usuario, string pass,
                                   List<RegistroClimatico> topFrios, List<RegistroClimatico> topCalientes)
        {
            string connString = $"Server={host};Port={puerto};Database={bd};Uid={usuario};Pwd={pass};";
            using var conn = new MySqlConnection(connString);
            conn.Open();

            // ── Crear tablas si no existen ────────────────────────────────────────
            string crearCalientes = @"
    CREATE TABLE IF NOT EXISTS ranking_mas_calientes (
        id              INT AUTO_INCREMENT PRIMARY KEY,
        exportacion_id  INT NOT NULL,
        posicion        INT NOT NULL,
        estado          VARCHAR(100) NOT NULL,
        temperatura     DOUBLE NOT NULL,
        fecha_registro  DATE NOT NULL,
        fecha_reporte   DATETIME NOT NULL
    );";
            new MySqlCommand(crearCalientes, conn).ExecuteNonQuery();

            string crearFrios = @"
    CREATE TABLE IF NOT EXISTS ranking_mas_frios (
        id              INT AUTO_INCREMENT PRIMARY KEY,
        exportacion_id  INT NOT NULL,
        posicion        INT NOT NULL,
        estado          VARCHAR(100) NOT NULL,
        temperatura     DOUBLE NOT NULL,
        fecha_registro  DATE NOT NULL,
        fecha_reporte   DATETIME NOT NULL
    );";
            new MySqlCommand(crearFrios, conn).ExecuteNonQuery();

            // ── Agregar exportacion_id si la tabla ya existía sin esa columna ─────
            string agregarColumnaCalientes = @"
    ALTER TABLE ranking_mas_calientes 
    ADD COLUMN IF NOT EXISTS exportacion_id INT NOT NULL DEFAULT 0;";
            new MySqlCommand(agregarColumnaCalientes, conn).ExecuteNonQuery();

            string agregarColumnaFrios = @"
    ALTER TABLE ranking_mas_frios 
    ADD COLUMN IF NOT EXISTS exportacion_id INT NOT NULL DEFAULT 0;";
            new MySqlCommand(agregarColumnaFrios, conn).ExecuteNonQuery();

            // ── Calcular el siguiente exportacion_id ──────────────────────────────
            // Tomamos el máximo actual de ambas tablas y sumamos 1
            string queryMaxId = @"
        SELECT COALESCE(MAX(exportacion_id), 0) 
        FROM (
            SELECT exportacion_id FROM ranking_mas_calientes
            UNION ALL
            SELECT exportacion_id FROM ranking_mas_frios
        ) AS combinado;";
            int nuevoId = Convert.ToInt32(new MySqlCommand(queryMaxId, conn).ExecuteScalar()) + 1;

            // ── Insertar top calientes ────────────────────────────────────────────
            for (int i = 0; i < topCalientes.Count; i++)
            {
                var r = topCalientes[i];
                string ins = @"INSERT INTO ranking_mas_calientes 
                       (exportacion_id, posicion, estado, temperatura, fecha_registro, fecha_reporte)
                       VALUES (@expId, @pos, @est, @temp, @fReg, NOW());";
                using var cmd = new MySqlCommand(ins, conn);
                cmd.Parameters.AddWithValue("@expId", nuevoId);
                cmd.Parameters.AddWithValue("@pos", i + 1);
                cmd.Parameters.AddWithValue("@est", r.Estado);
                cmd.Parameters.AddWithValue("@temp", r.MaxC);
                cmd.Parameters.AddWithValue("@fReg", r.Periodo.ToDateTime(TimeOnly.MinValue));
                cmd.ExecuteNonQuery();
            }

            // ── Insertar top fríos ────────────────────────────────────────────────
            for (int i = 0; i < topFrios.Count; i++)
            {
                var r = topFrios[i];
                string ins = @"INSERT INTO ranking_mas_frios 
                       (exportacion_id, posicion, estado, temperatura, fecha_registro, fecha_reporte)
                       VALUES (@expId, @pos, @est, @temp, @fReg, NOW());";
                using var cmd = new MySqlCommand(ins, conn);
                cmd.Parameters.AddWithValue("@expId", nuevoId);
                cmd.Parameters.AddWithValue("@pos", i + 1);
                cmd.Parameters.AddWithValue("@est", r.Estado);
                cmd.Parameters.AddWithValue("@temp", r.MinC);
                cmd.Parameters.AddWithValue("@fReg", r.Periodo.ToDateTime(TimeOnly.MinValue));
                cmd.ExecuteNonQuery();
            }
        }
    }

}