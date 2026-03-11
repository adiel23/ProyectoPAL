using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAL
{
    internal class UserRepository
    {
        public static void Insert(string username, string password)
        {
            using (var conn = new SQLiteConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                string sql = "INSERT INTO users (username, password) VALUES (@username, @password)";
                using (var command = new SQLiteCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateBalance(double balance)
        {
            using (var conn = new SQLiteConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                string sql = "update users set balance = @balance";
                using(var command = new SQLiteCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@balance", balance);
                }
            }

        }
    }
}
