using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Reminder
{
    public class DatabaseConnection
    {
        SQLiteConnection connection;

        public DatabaseConnection(string DataSource)
        {
            this.connection = new SQLiteConnection(DataSource);
            CreateDatabaseStructure();
        }
        private void CreateDatabaseStructure()
        {
            this.connection.Open();

            string stm = "CREATE TABLE IF NOT EXISTS dates(" +
                "date TEXT NOT NULL, message TEXT NOT NULL, " +
                "important INTEGER NOT NULL, " +
                "constant INTEGER NOT NULL)";
            var command = new SQLiteCommand(stm, this.connection);
            command.ExecuteNonQuery();
        }

        public void AddToDB(string date, string text, bool important, bool constant)
        {
            int imp = 0, con = 0;
            if (important) imp = 1;
            if (constant) con = 1;
            string stm = "INSERT INTO dates(date, message, important, constant) " +
                "VALUES ('" + date + "', '" + text + "', " + imp + ", " + con + ")";

            var command = new SQLiteCommand(stm, this.connection);
            command.ExecuteNonQuery();
        }
        public void DeleteFromDB(int id)
        {
            string stm = "DELETE FROM dates WHERE rowid=" + id;

            var command = new SQLiteCommand(stm, this.connection);
            command.ExecuteNonQuery();
        }
        public SQLiteDataReader SendQuery(string SQL_Query)
        {
            var cmd = new SQLiteCommand(SQL_Query, this.connection);

            return cmd.ExecuteReader();
        }
        public int GetMaxId()
        {
            string SQL_Query = "SELECT MAX(rowid) FROM dates";
            var cmd = new SQLiteCommand(SQL_Query, this.connection);
            int id = Convert.ToInt32(cmd.ExecuteScalar());

            return id;
        }
    }
}
