namespace Reminder
{
    partial class ReminderConfig_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Important = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Constant = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.add = new System.Windows.Forms.Button();
            this.dayOfWeek = new System.Windows.Forms.ComboBox();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.radio_date = new System.Windows.Forms.RadioButton();
            this.radio_dayOfWeek = new System.Windows.Forms.RadioButton();
            this.dateType = new System.Windows.Forms.GroupBox();
            this.delete = new System.Windows.Forms.Button();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.dateType.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.date,
            this.message,
            this.Important,
            this.Constant});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(443, 232);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 43;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 55;
            // 
            // message
            // 
            this.message.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.message.HeaderText = "Message";
            this.message.Name = "message";
            this.message.ReadOnly = true;
            // 
            // Important
            // 
            this.Important.HeaderText = "Important";
            this.Important.Name = "Important";
            this.Important.ReadOnly = true;
            this.Important.Width = 57;
            // 
            // Constant
            // 
            this.Constant.HeaderText = "Constant";
            this.Constant.Name = "Constant";
            this.Constant.ReadOnly = true;
            this.Constant.Width = 55;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd/MM";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(12, 295);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(122, 20);
            this.dateTimePicker.TabIndex = 1;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(381, 295);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 2;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // dayOfWeek
            // 
            this.dayOfWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dayOfWeek.FormattingEnabled = true;
            this.dayOfWeek.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.dayOfWeek.Location = new System.Drawing.Point(151, 296);
            this.dayOfWeek.Name = "dayOfWeek";
            this.dayOfWeek.Size = new System.Drawing.Size(101, 21);
            this.dayOfWeek.TabIndex = 4;
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(258, 267);
            this.messageBox.MaxLength = 30;
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(198, 20);
            this.messageBox.TabIndex = 3;
            // 
            // radio_date
            // 
            this.radio_date.AutoSize = true;
            this.radio_date.Checked = true;
            this.radio_date.Location = new System.Drawing.Point(6, 19);
            this.radio_date.Name = "radio_date";
            this.radio_date.Size = new System.Drawing.Size(48, 17);
            this.radio_date.TabIndex = 4;
            this.radio_date.TabStop = true;
            this.radio_date.Text = "Date";
            this.radio_date.UseVisualStyleBackColor = true;
            // 
            // radio_dayOfWeek
            // 
            this.radio_dayOfWeek.AutoSize = true;
            this.radio_dayOfWeek.Location = new System.Drawing.Point(139, 17);
            this.radio_dayOfWeek.Name = "radio_dayOfWeek";
            this.radio_dayOfWeek.Size = new System.Drawing.Size(85, 17);
            this.radio_dayOfWeek.TabIndex = 5;
            this.radio_dayOfWeek.Text = "Day of week";
            this.radio_dayOfWeek.UseVisualStyleBackColor = true;
            // 
            // dateType
            // 
            this.dateType.Controls.Add(this.radio_date);
            this.dateType.Controls.Add(this.radio_dayOfWeek);
            this.dateType.Location = new System.Drawing.Point(12, 250);
            this.dateType.Name = "dateType";
            this.dateType.Size = new System.Drawing.Size(240, 40);
            this.dateType.TabIndex = 6;
            this.dateType.TabStop = false;
            this.dateType.Text = "Type of date";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(258, 295);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(117, 23);
            this.delete.TabIndex = 7;
            this.delete.Text = "Delete selected";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // checkedListBox
            // 
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Items.AddRange(new object[] {
            "Important",
            "Constant"});
            this.checkedListBox.Location = new System.Drawing.Point(12, 323);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(122, 34);
            this.checkedListBox.TabIndex = 8;
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.close.Location = new System.Drawing.Point(381, 334);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(74, 23);
            this.close.TabIndex = 9;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // ReminderConfig_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 373);
            this.Controls.Add(this.close);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.dayOfWeek);
            this.Controls.Add(this.dateType);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ReminderConfig_Form";
            this.Text = "Reminder Config";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.dateType.ResumeLayout(false);
            this.dateType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.ComboBox dayOfWeek;
        private System.Windows.Forms.RadioButton radio_date;
        private System.Windows.Forms.RadioButton radio_dayOfWeek;
        private System.Windows.Forms.GroupBox dateType;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn message;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Important;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Constant;
    }
}