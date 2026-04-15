using InteligenciaClimatica.Models;
using MySqlConnector;
using System;
using Microsoft.Data.Sqlite;

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
                string cadenaConexion = $"Data Source={rutaArchivo};";

                // Si el archivo no existe, la librería lo creará automáticamente al intentar conectar
                using var conexion = new SqliteConnection(cadenaConexion);
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
        public async Task GuardarAlertaMariaDB(string servidor, string puerto, string bd, string usuario, string password,
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
            await conexion.OpenAsync();

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

            string queryInsert = @"
        INSERT INTO AlertasClimaticas 
        (FechaRegistro, Municipio, Estado, TemperaturaActual, PromedioHistorico, Anomalia) 
        VALUES (@fecha, @mun, @est, @actual, @hist, @anom);";

            using var cmdInsert = new MySqlCommand(queryInsert, conexion);

            cmdInsert.Parameters.AddWithValue("@fecha", DateTime.Now);
            cmdInsert.Parameters.AddWithValue("@mun", municipio);
            cmdInsert.Parameters.AddWithValue("@est", estado);
            cmdInsert.Parameters.AddWithValue("@actual", tempActual);
            cmdInsert.Parameters.AddWithValue("@hist", tempHistorica);
            cmdInsert.Parameters.AddWithValue("@anom", anomalia);

            await cmdInsert.ExecuteNonQueryAsync();
        }

        public void GuardarRankingMariaDB(string host, string puerto, string bd, string usuario, string pass,
                                   List<RegistroClimatico> topFrios, List<RegistroClimatico> topCalientes)
        {
            string connString = $"Server={host};Port={puerto};Database={bd};Uid={usuario};Pwd={pass};";
            using var conn = new MySqlConnection(connString);
            conn.Open();

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

            string agregarColumnaCalientes = @"
    ALTER TABLE ranking_mas_calientes 
    ADD COLUMN IF NOT EXISTS exportacion_id INT NOT NULL DEFAULT 0;";
            new MySqlCommand(agregarColumnaCalientes, conn).ExecuteNonQuery();

            string agregarColumnaFrios = @"
    ALTER TABLE ranking_mas_frios 
    ADD COLUMN IF NOT EXISTS exportacion_id INT NOT NULL DEFAULT 0;";
            new MySqlCommand(agregarColumnaFrios, conn).ExecuteNonQuery();

            string queryMaxId = @"
        SELECT COALESCE(MAX(exportacion_id), 0) 
        FROM (
            SELECT exportacion_id FROM ranking_mas_calientes
            UNION ALL
            SELECT exportacion_id FROM ranking_mas_frios
        ) AS combinado;";
            int nuevoId = Convert.ToInt32(new MySqlCommand(queryMaxId, conn).ExecuteScalar()) + 1;

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

        // ══════════════════════════════════════════════════════════════════
        // SQLITE: INICIALIZACIÓN
        // ══════════════════════════════════════════════════════════════════

        public async Task InicializarBaseDatosLocalAsync(string rutaArchivo)
        {
            string cadenaConexion = $"Data Source={rutaArchivo};";
            using var conexion = new SqliteConnection(cadenaConexion);
            await conexion.OpenAsync();

            string queryTablas = @"
                CREATE TABLE IF NOT EXISTS Configuracion (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Umbral REAL,
                    RutaCSV TEXT,
                    RutaJSON TEXT
                );

                CREATE TABLE IF NOT EXISTS Favoritos (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Estado TEXT NOT NULL,
                    Municipio TEXT NOT NULL,
                    FechaAgregado DATETIME NOT NULL
                );

                CREATE TABLE IF NOT EXISTS HistorialConsultas (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Estado TEXT,
                    Municipio TEXT,
                    FechaConsulta DATETIME NOT NULL
                );";

            using var cmd = new SqliteCommand(queryTablas, conexion);
            await cmd.ExecuteNonQueryAsync();
        }

        // ══════════════════════════════════════════════════════════════════
        // SQLITE: CRUD DE FAVORITOS
        // ══════════════════════════════════════════════════════════════════

        public async Task AgregarFavoritoAsync(string rutaArchivo, string estado, string municipio)
        {
            string cadenaConexion = $"Data Source={rutaArchivo};";
            using var conexion = new SqliteConnection(cadenaConexion);
            await conexion.OpenAsync();

            string query = @"
                INSERT INTO Favoritos (Estado, Municipio, FechaAgregado) 
                VALUES (@est, @mun, @fecha);";

            using var cmd = new SqliteCommand(query, conexion);
            cmd.Parameters.AddWithValue("@est", estado);
            cmd.Parameters.AddWithValue("@mun", municipio);
            // Sqlite prefiere las fechas en formato texto ISO 8601
            cmd.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            await cmd.ExecuteNonQueryAsync();
        }

        public async Task<List<string>> ObtenerFavoritosAsync(string rutaArchivo)
        {
            var listaFavoritos = new List<string>();
            string cadenaConexion = $"Data Source={rutaArchivo};";

            using var conexion = new SqliteConnection(cadenaConexion);
            await conexion.OpenAsync();

            string query = "SELECT Estado, Municipio FROM Favoritos ORDER BY FechaAgregado DESC;";
            using var cmd = new SqliteCommand(query, conexion);
            using var reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                string estado = reader.GetString(0);
                string municipio = reader.GetString(1);
                listaFavoritos.Add($"{municipio}, {estado}");
            }

            return listaFavoritos;
        }

        public async Task EliminarFavoritoAsync(string rutaArchivo, string estado, string municipio)
        {
            string cadenaConexion = $"Data Source={rutaArchivo};";
            using var conexion = new SqliteConnection(cadenaConexion);
            await conexion.OpenAsync();

            string query = "DELETE FROM Favoritos WHERE Estado = @est AND Municipio = @mun;";
            using var cmd = new SqliteCommand(query, conexion);
            cmd.Parameters.AddWithValue("@est", estado);
            cmd.Parameters.AddWithValue("@mun", municipio);

            await cmd.ExecuteNonQueryAsync();
        }
        public async Task MigrarFavoritosASQLiteAsync(string rutaArchivo, List<(string Estado, string Municipio)> nuevosFavoritos)
        {
            string cadenaConexion = $"Data Source={rutaArchivo};";
            using var conexion = new SqliteConnection(cadenaConexion);
            await conexion.OpenAsync();

            // ════════════════════════════════════════════════════════════════════
            // BLOQUE AUTO-REPARADOR: Fuerza la creación de la columna si falta
            // ════════════════════════════════════════════════════════════════════
            try
            {
                string fixQuery = "ALTER TABLE Favoritos ADD COLUMN FechaAgregado DATETIME;";
                using var cmdFix = new SqliteCommand(fixQuery, conexion);
                await cmdFix.ExecuteNonQueryAsync();
            }
            catch
            {
                // Si entra aquí, significa que la columna ya existía o la tabla es nueva.
                // Lo ignoramos silenciosamente para que el programa no se detenga.
            }
            // ════════════════════════════════════════════════════════════════════

            // Iniciamos la transacción para la migración
            using var transaccion = conexion.BeginTransaction();

            string query = @"
        INSERT INTO Favoritos (Estado, Municipio, FechaAgregado) 
        SELECT @est, @mun, @fecha
        WHERE NOT EXISTS (
            SELECT 1 FROM Favoritos WHERE Estado = @est AND Municipio = @mun
        );";

            using var cmd = new SqliteCommand(query, conexion, transaccion);

            cmd.Parameters.Add("@est", SqliteType.Text);
            cmd.Parameters.Add("@mun", SqliteType.Text);
            cmd.Parameters.Add("@fecha", SqliteType.Text);

            foreach (var fav in nuevosFavoritos)
            {
                cmd.Parameters["@est"].Value = fav.Estado;
                cmd.Parameters["@mun"].Value = fav.Municipio;
                cmd.Parameters["@fecha"].Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                await cmd.ExecuteNonQueryAsync();
            }

            await transaccion.CommitAsync();
        }
    }
}