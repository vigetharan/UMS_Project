using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicomTICManagementSystem.Repositories
{
    public static class DatabaseManager
    {
        private static string connectionString = "Data Source=UnicomDB.db;Version=3;";

        public static SQLiteConnection GetConnection()
        {
            try
            {
                var conn = new SQLiteConnection(connectionString);
                conn.Open();
                return conn;
            }
            catch (System.Data.SQLite.SQLiteException sqlex)
            {
                MessageBox.Show($"SQLite error opening database:\n{sqlex.Message}",
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw; // rethrow so upstream code knows the connection failed
            }
            catch (Exception ex)
            {
                // Handle any other unexpected errors
                MessageBox.Show($"Unexpected error opening database:\n{ex.Message}",
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
