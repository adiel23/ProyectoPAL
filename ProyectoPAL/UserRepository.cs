using ProyectoPAL.Models;
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
        public static User? FindUser(string username)
        {
            using (var connection = new SQLiteConnection(DatabaseHelper.ConnectionString))
            {
                connection.Open();
                string query = "select * from users where username = @username";
                using(var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read()) // Avanza a la primera fila
                        {
                            return new User
                            {
                                id = reader.GetInt32(reader.GetOrdinal("id")),
                                username = reader.GetString(reader.GetOrdinal("username")),
                                password = reader.GetString(reader.GetOrdinal("password")),
                                balance = reader.GetDouble(reader.GetOrdinal("balance"))
                            };
                        }
                    }
                }
            }
            return null;
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
