
namespace KURSACH
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.date3TextBox = new System.Windows.Forms.TextBox();
            this.date2TextBox = new System.Windows.Forms.TextBox();
            this.date1TextBox = new System.Windows.Forms.TextBox();
            this.DatePeriodFilter = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DateFilter = new System.Windows.Forms.Button();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.UpdateInfoButton = new System.Windows.Forms.Button();
            this.DeleteContractButton = new System.Windows.Forms.Button();
            this.ReloadTableButton = new System.Windows.Forms.Button();
            this.InsertContractButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.IdTextBoxMain = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Tan;
            this.panel2.Controls.Add(this.date3TextBox);
            this.panel2.Controls.Add(this.date2TextBox);
            this.panel2.Controls.Add(this.date1TextBox);
            this.panel2.Controls.Add(this.DatePeriodFilter);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.DateFilter);
            this.panel2.Controls.Add(this.dateTimePicker3);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1178, 45);
            this.panel2.TabIndex = 2;
            // 
            // date3TextBox
            // 
            this.date3TextBox.Location = new System.Drawing.Point(668, 12);
            this.date3TextBox.Name = "date3TextBox";
            this.date3TextBox.Size = new System.Drawing.Size(85, 20);
            this.date3TextBox.TabIndex = 14;
            this.date3TextBox.Visible = false;
            // 
            // date2TextBox
            // 
            this.date2TextBox.Location = new System.Drawing.Point(577, 12);
            this.date2TextBox.Name = "date2TextBox";
            this.date2TextBox.Size = new System.Drawing.Size(85, 20);
            this.date2TextBox.TabIndex = 13;
            this.date2TextBox.Visible = false;
            // 
            // date1TextBox
            // 
            this.date1TextBox.Location = new System.Drawing.Point(216, 12);
            this.date1TextBox.Name = "date1TextBox";
            this.date1TextBox.Size = new System.Drawing.Size(85, 20);
            this.date1TextBox.TabIndex = 12;
            this.date1TextBox.Visible = false;
            // 
            // DatePeriodFilter
            // 
            this.DatePeriodFilter.Location = new System.Drawing.Point(307, 11);
            this.DatePeriodFilter.Name = "DatePeriodFilter";
            this.DatePeriodFilter.Size = new System.Drawing.Size(70, 23);
            this.DatePeriodFilter.TabIndex = 11;
            this.DatePeriodFilter.TabStop = false;
            this.DatePeriodFilter.Text = "За период";
            this.DatePeriodFilter.UseVisualStyleBackColor = true;
            this.DatePeriodFilter.Click += new System.EventHandler(this.DatePeriodFilter_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(119, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(91, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.TabStop = false;
            this.dateTimePicker1.Value = new System.DateTime(2021, 1, 9, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // DateFilter
            // 
            this.DateFilter.Location = new System.Drawing.Point(9, 11);
            this.DateFilter.Name = "DateFilter";
            this.DateFilter.Size = new System.Drawing.Size(104, 23);
            this.DateFilter.TabIndex = 8;
            this.DateFilter.TabStop = false;
            this.DateFilter.Text = "Фильтр по дате";
            this.DateFilter.UseVisualStyleBackColor = true;
            this.DateFilter.Click += new System.EventHandler(this.DateFilter_Click);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(480, 12);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(91, 20);
            this.dateTimePicker3.TabIndex = 9;
            this.dateTimePicker3.TabStop = false;
            this.dateTimePicker3.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(383, 12);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(91, 20);
            this.dateTimePicker2.TabIndex = 10;
            this.dateTimePicker2.TabStop = false;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Plum;
            this.panel3.Controls.Add(this.labelSearch);
            this.panel3.Controls.Add(this.textBoxSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1178, 38);
            this.panel3.TabIndex = 3;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(6, 12);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(39, 13);
            this.labelSearch.TabIndex = 4;
            this.labelSearch.Text = "Поиск";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(51, 9);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(175, 20);
            this.textBoxSearch.TabIndex = 6;
            this.textBoxSearch.TabStop = false;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.Controls.Add(this.UpdateInfoButton);
            this.panel4.Controls.Add(this.DeleteContractButton);
            this.panel4.Controls.Add(this.ReloadTableButton);
            this.panel4.Controls.Add(this.InsertContractButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 83);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1178, 40);
            this.panel4.TabIndex = 4;
            // 
            // UpdateInfoButton
            // 
            this.UpdateInfoButton.Location = new System.Drawing.Point(308, 3);
            this.UpdateInfoButton.Name = "UpdateInfoButton";
            this.UpdateInfoButton.Size = new System.Drawing.Size(93, 34);
            this.UpdateInfoButton.TabIndex = 4;
            this.UpdateInfoButton.TabStop = false;
            this.UpdateInfoButton.Text = "Редактировать";
            this.UpdateInfoButton.UseVisualStyleBackColor = true;
            this.UpdateInfoButton.Click += new System.EventHandler(this.UpdateInfoButton_Click);
            // 
            // DeleteContractButton
            // 
            this.DeleteContractButton.Location = new System.Drawing.Point(407, 3);
            this.DeleteContractButton.Name = "DeleteContractButton";
            this.DeleteContractButton.Size = new System.Drawing.Size(83, 34);
            this.DeleteContractButton.TabIndex = 5;
            this.DeleteContractButton.TabStop = false;
            this.DeleteContractButton.Text = "Удалить";
            this.DeleteContractButton.UseVisualStyleBackColor = true;
            this.DeleteContractButton.Click += new System.EventHandler(this.DeleteContractButton_Click);
            // 
            // ReloadTableButton
            // 
            this.ReloadTableButton.Location = new System.Drawing.Point(6, 3);
            this.ReloadTableButton.Name = "ReloadTableButton";
            this.ReloadTableButton.Size = new System.Drawing.Size(120, 34);
            this.ReloadTableButton.TabIndex = 2;
            this.ReloadTableButton.TabStop = false;
            this.ReloadTableButton.Text = "Обновить таблицу";
            this.ReloadTableButton.UseVisualStyleBackColor = true;
            this.ReloadTableButton.Click += new System.EventHandler(this.ReloadTableButton_Click);
            // 
            // InsertContractButton
            // 
            this.InsertContractButton.Location = new System.Drawing.Point(219, 3);
            this.InsertContractButton.Name = "InsertContractButton";
            this.InsertContractButton.Size = new System.Drawing.Size(83, 34);
            this.InsertContractButton.TabIndex = 3;
            this.InsertContractButton.TabStop = false;
            this.InsertContractButton.Text = "Добавить";
            this.InsertContractButton.UseVisualStyleBackColor = true;
            this.InsertContractButton.Click += new System.EventHandler(this.InsertContractButton_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Tan;
            this.panel5.Controls.Add(this.IdTextBoxMain);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 604);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1178, 46);
            this.panel5.TabIndex = 5;
            // 
            // IdTextBoxMain
            // 
            this.IdTextBoxMain.Location = new System.Drawing.Point(9, 14);
            this.IdTextBoxMain.Name = "IdTextBoxMain";
            this.IdTextBoxMain.ReadOnly = true;
            this.IdTextBoxMain.Size = new System.Drawing.Size(100, 20);
            this.IdTextBoxMain.TabIndex = 6;
            this.IdTextBoxMain.TabStop = false;
            this.IdTextBoxMain.Text = "1";
            this.IdTextBoxMain.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.Gray;
            this.dataGridView1.Location = new System.Drawing.Point(0, 123);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1178, 481);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 650);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автоматизация учета договоров";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button DatePeriodFilter;
        private System.Windows.Forms.Button DateFilter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button InsertContractButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button ReloadTableButton;
        private System.Windows.Forms.Button DeleteContractButton;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button UpdateInfoButton;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.DateTimePicker dateTimePicker3;
        public System.Windows.Forms.DateTimePicker dateTimePicker2;
        public System.Windows.Forms.TextBox textBoxSearch;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox IdTextBoxMain;
        public System.Windows.Forms.TextBox date3TextBox;
        public System.Windows.Forms.TextBox date2TextBox;
        public System.Windows.Forms.TextBox date1TextBox;
    }
}

