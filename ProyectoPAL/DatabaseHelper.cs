using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using System.IO;    

namespace ProyectoPAL
{
    internal class DatabaseHelper
    {
        private static string dbRoute = Path.Combine(Application.StartupPath, "ProyectoPAL.db");
        public static string ConnectionString = $"Data Source={dbRoute}";

        public static void InitializeDB()
        {
            using (var conn = new SqliteConnection(ConnectionString))
            {
                conn.Open();

                string crearTabla = @"
                    CREATE TABLE IF NOT EXISTS users (
                        id      INTEGER PRIMARY KEY AUTOINCREMENT,
                        username    TEXT    NOT NULL,
                        password    TEXT    NOT NULL,
                        balance     REAL    NOT NULL DEFAULT 0.0
                    );";

                using (var command = new SqliteCommand(crearTabla, conn))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
