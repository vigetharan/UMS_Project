using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Repositories
{
    public static class DatabaseManager
        {
            private static string connectionString = "Data Source=UnicomDB.db;Version=3;";

            public static SQLiteConnection GetConnection()
            {
                var conn = new SQLiteConnection(connectionString);
                conn.Open();
                return conn;
            }
        }
}
