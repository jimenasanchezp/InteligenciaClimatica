using System;
using System.Data.SQLite;
using MySqlConnector;

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
    }
}