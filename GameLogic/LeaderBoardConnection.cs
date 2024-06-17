using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

namespace GameLogic
{


    public class LeaderBoardConnection
    {
        private string connectionString;
        private readonly string DATABASE_FILE = "leaderboard.sql";

        public LeaderBoardConnection()
        {
            connectionString = $"Data Source={DATABASE_FILE};Version=3;";
            if (!File.Exists(DATABASE_FILE))
            {
                CreateDatabase(DATABASE_FILE);
            }
        }

        private void CreateDatabase(string databaseFile)
        {
            SQLiteConnection.CreateFile(databaseFile);
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string createTableQuery = @"CREATE TABLE LeaderBoard (
                                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                            Name TEXT NOT NULL,
                                            Time LONG NOT NULL
                                        );";
                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public void AddToBoard(string name, long time)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string insertQuery = "INSERT INTO LeaderBoard (Name, Time) VALUES (@Name, @Time)";
                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Time", time);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<(int id, string Name, long Time)> GetLeaderBoard()
        {
            var leaderBoard = new List<(int id, string Name, long Time)>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT Id, Name, Time FROM LeaderBoard ORDER BY Time ASC LIMIT 3";
                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string name = reader.GetString(1);
                            int time = reader.GetInt32(2);
                            leaderBoard.Add((id, name, time));
                        }
                    }
                }
            }
            return leaderBoard;
        }

        public void RemoveFromBoardById(int id)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string deleteQuery = "DELETE FROM LeaderBoard WHERE Id = @Id";
                using (var command = new SQLiteCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
