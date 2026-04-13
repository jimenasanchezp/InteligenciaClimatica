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

        public void GuardarRankingMariaDB(string host, string puerto, string bd, string usuario, string pass, List<RegistroClimatico> topFrios, List<RegistroClimatico> topCalientes)
        {
            string connString = $"Server={host};Port={puerto};Database={bd};Uid={usuario};Pwd={pass};";
            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();

                // Crear la tabla de ranking si no existe
                string createTable = @"CREATE TABLE IF NOT EXISTS ranking_climatico (
            id INT AUTO_INCREMENT PRIMARY KEY,
            tipo_ranking VARCHAR(20),
            estado VARCHAR(100),
            temperatura DOUBLE,
            fecha_registro DATE,
            fecha_reporte DATETIME
        );";
                new MySqlCommand(createTable, conn).ExecuteNonQuery();

                // Limpiamos datos viejos para tener un ranking fresco
                new MySqlCommand("TRUNCATE TABLE ranking_climatico;", conn).ExecuteNonQuery();

                // Insertar Top Calientes
                foreach (var r in topCalientes)
                {
                    string ins = "INSERT INTO ranking_climatico (tipo_ranking, estado, temperatura, fecha_registro, fecha_reporte) " +
                                 "VALUES ('CALIENTE', @est, @temp, @fReg, NOW());";
                    var cmd = new MySqlCommand(ins, conn);
                    cmd.Parameters.AddWithValue("@est", r.Estado);
                    cmd.Parameters.AddWithValue("@temp", r.MaxC);
                    cmd.Parameters.AddWithValue("@fReg", r.Periodo);
                    cmd.ExecuteNonQuery();
                }

                // Insertar Top Fríos
                foreach (var r in topFrios)
                {
                    string ins = "INSERT INTO ranking_climatico (tipo_ranking, estado, temperatura, fecha_registro, fecha_reporte) " +
                                 "VALUES ('FRIO', @est, @temp, @fReg, NOW());";
                    var cmd = new MySqlCommand(ins, conn);
                    cmd.Parameters.AddWithValue("@est", r.Estado);
                    cmd.Parameters.AddWithValue("@temp", r.MinC);
                    cmd.Parameters.AddWithValue("@fReg", r.Periodo);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }

}