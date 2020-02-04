using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Reminder
{
    public partial class ReminderConfig_Form : Form
    {
        DatabaseConnection db;
        public ReminderConfig_Form()
        {
            InitializeComponent();
            db = new DatabaseConnection("Data Source =database.db");
            this.dayOfWeek.SelectedIndex = 0;
            FillTableWithData();
        }
        private void FillTableWithData()
        {
            string query = "SELECT rowid, date, message, important, constant FROM dates";
            SQLiteDataReader results = db.SendQuery(query);

            while (results.Read())
            {
                bool important, constant;

                if ((int)results.GetInt32(3) == 1) important = true;
                else important = false;

                if ((int)results.GetInt32(4) == 1) constant = true;
                else constant = false;

                dataGridView1.Rows.Add(new object[]
                {
                    results.GetInt32(0),
                    results.GetString(1),
                    results.GetString(2),
                    important,
                    constant
                });
            }
        }
        

        private void add_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private void AddData()
        {
            string date;
            if (radio_date.Checked)
                date = dateTimePicker.Text;
            else
                date = dayOfWeek.Text;

            if (String.IsNullOrEmpty(messageBox.Text))
                messageBox.Text = "Default message";

            bool important = checkedListBox.GetItemCheckState(0) == CheckState.Checked;
            bool constant = checkedListBox.GetItemCheckState(1) == CheckState.Checked;

            try
            {
                db.AddToDB(date, messageBox.Text, important, constant);
                UpdateTable(date, important, constant);
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
            }
            catch (Exception e)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(e.ToString(), "Error", buttons);
            }
        }
        private void UpdateTable(string date, bool important, bool constant)
        {
            
            dataGridView1.Rows.Add(new object[]
            {
                db.GetMaxId(),
                date,
                messageBox.Text,
                important,
                constant
            });
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            db.DeleteFromDB(id);

            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }
    }
}
