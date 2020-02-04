using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Globalization;

namespace Reminder
{
    static class Reminder
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DatabaseConnection db = new DatabaseConnection("Data Source =database.db");
            

            DeletePastEvents(db);
            string message = FetchTodayEvents(db);

            if (!String.IsNullOrEmpty(message))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new mainWindow(message));
            }
            else
                Application.Exit();
        }
        private static void DeletePastEvents(DatabaseConnection db)
        {
            string date = DateTime.Today.ToString();
            string query = "SELECT rowid, date FROM dates WHERE constant = 0";
            SQLiteDataReader results = db.SendQuery(query);

            int resultId;
            string resultDate;
            DateTime convertedDate;

            while (results.Read())
            {
                resultId = results.GetInt32(0);
                resultDate = results.GetString(1);

                if(DateTime.TryParse(resultDate, out convertedDate)) //ignore day of week
                {
                    DateTime.TryParseExact(results.GetString(1), "dd/MM", CultureInfo.InvariantCulture, DateTimeStyles.None, out convertedDate);

                    if (DateTime.Compare(convertedDate, DateTime.Today) < 0)
                        db.DeleteFromDB(resultId);
                }
            }
        }
        private static string FetchTodayEvents(DatabaseConnection db)
        {
            string date = DateTime.Today.ToString("dd/MM", CultureInfo.InvariantCulture);
            string dayOfWeek = DateTime.Today.DayOfWeek.ToString();
            string query = "SELECT rowid, message, date FROM dates WHERE date='" + date + "' OR date='" + dayOfWeek + "'";
            SQLiteDataReader results = db.SendQuery(query);

            string finalMessage = "";

            int result_id;
            string result_message;
            string result_date;

            while (results.Read())
            {
                result_id = results.GetInt32(0);
                result_message = results.GetString(1);
                result_date = results.GetString(2);
                finalMessage += result_message + "\n";
            }

            return finalMessage;
        }
    }
}
