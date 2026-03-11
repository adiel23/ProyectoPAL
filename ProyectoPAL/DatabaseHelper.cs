using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace ProyectoPAL
{
    internal class DatabaseHelper
    {
        private static string dbRoute = Path.Combine(Application.StartupPath, "ProyectoPAL.db");
        public static string ConnectionString = $"Data Source={dbRoute};Version=3;";

        public static void InitializeDB()
        {
            if (!File.Exists(dbRoute))
            {
                SQLiteConnection.CreateFile(dbRoute);
            }

            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();

                string crearTabla = @"
                    CREATE TABLE IF NOT EXISTS users (
                        id      INTEGER PRIMARY KEY AUTOINCREMENT,
                        username    TEXT    NOT NULL,
                        password    TEXT    NOT NULL,
                        balance     REAL    NOT NULL DEFAULT 0.0
                    );";

                using (var command = new SQLiteCommand(crearTabla, conn))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
