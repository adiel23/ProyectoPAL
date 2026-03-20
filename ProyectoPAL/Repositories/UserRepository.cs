using Microsoft.Data.Sqlite;
using ProyectoPAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPAL.Repositories
{
    internal class UserRepository
    {
        public static void Insert(string username, string password)
        {
            using (var conn = new SqliteConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                string sql = "INSERT INTO users (username, password) VALUES (@username, @password)";
                using (var command = new SqliteCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.ExecuteNonQuery();
                }
            }
        }
        public static User? FindUser(string username)
        {
            using (var connection = new SqliteConnection(DatabaseHelper.ConnectionString))
            {
                connection.Open();
                string query = "select * from users where username = @username";
                using(var command = new SqliteCommand(query, connection))
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

        public static User? FindUserById(int id)
        {
            using (var conn = new SqliteConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();

                string query = "select * from users where id = @id";

                using(var command = new SqliteCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                id = reader.GetInt32(reader.GetOrdinal("id")),
                                username = reader.GetString(reader.GetOrdinal("username")),
                                balance = reader.GetDouble(reader.GetOrdinal("balance"))
                            };
                        }
                    }
                    
                }
            }

            return null;
        }

        public static void UpdateBalance(int userId, double amount)
        {
            using (var conn = new SqliteConnection(DatabaseHelper.ConnectionString))
            {
                conn.Open();
                string sql = "update users set balance = balance + @amount where id = @userId";
                using(var command = new SqliteCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@userId", userId);
                    command.Parameters.AddWithValue("@amount", amount);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateBalance(int userId, double amount, SqliteConnection connection, SqliteTransaction transaction)
        {
            string query = "update users set balance = balance + @amount where id = @userId";

            using var command = new SqliteCommand(query, connection);
            command.Transaction = transaction;
            command.Parameters.AddWithValue("@userId", userId);
            command.Parameters.AddWithValue("@amount", amount);
            command.ExecuteNonQuery();

        }
    }
}
