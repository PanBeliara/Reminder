using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ReminderConfig
{
    public partial class Form1 : Form
    {
        DataBaseConnection db;
        public Form1()
        {
            InitializeComponent();
            db = new DataBaseConnection("Data Source =database.db");
            this.dayOfWeek.SelectedIndex = 0;
            FillWithData();
        }
        private void FillWithData()
        {
            string query = "SELECT rowid, date, message FROM dates";
            SQLiteDataReader results = db.SendQuery(query);

            while (results.Read())
            {
                dataGridView1.Rows.Add(new object[]
                {
                    results.GetValue(0),
                    results.GetValue(1),
                    results.GetValue(2)
                });
            }
        }
    }
    class DataBaseConnection
    {
        SQLiteConnection connection;

        public DataBaseConnection(string DataSource)
        {
            this.connection = new SQLiteConnection(DataSource);
            CreateDatabaseStructure();
        }

        public void AddToDB(string date, string text)
        {
            string stm = "INSERT INTO dates(date, message) VALUES ('" + date + "', '" + text + "')";

            var command = new SQLiteCommand(stm, connection);
            command.ExecuteNonQuery();
        }
        public void DeleteFromDB(int id)
        {
            string stm = "DELETE FROM dates WHERE rowid=" + id;

            var command = new SQLiteCommand(stm, connection);
            command.ExecuteNonQuery();
        }
        public SQLiteDataReader SendQuery(string SQL_Query)
        {
            var cmd = new SQLiteCommand(SQL_Query, connection);

            return cmd.ExecuteReader();
        }

        private void CreateDatabaseStructure()
        {
            connection.Open();

            string stm;
            SQLiteCommand command;
            /*
            stm = "DROP TABLE IF EXISTS dates";
            command = new SQLiteCommand(stm, connection);
            command.ExecuteNonQuery();
            */
            stm = "CREATE TABLE IF NOT EXISTS dates(date TEXT NOT NULL, message TEXT NOT NULL)";
            command = new SQLiteCommand(stm, connection);
            command.ExecuteNonQuery();
        }
    }
}
