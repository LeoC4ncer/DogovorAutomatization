using System;
using System.Windows.Forms;
using System.IO;

namespace KURSACH
{
    public partial class MainForm : Form
    {
        OperationWithTable owt = new OperationWithTable();
        OperationWithContracts owc = new OperationWithContracts();
        ContractFilters cf = new ContractFilters();

        public MainForm()
        {
            OperationWithTable.mf = this;
            OperationWithContracts.mf = this;
            ContractFilters.mf = this;
            InitializeComponent();
        }

        public void MainForm_Load(object sender, EventArgs e)
        {
            string path = @"ContractsDataBase.sdf";
            if (File.Exists(path))
            {
                owt.LoadTable();
                IdTextBoxMain.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            }
            else
            {
                MessageBox.Show("База данных не найдена!", "Ошибка базы данных", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void ReloadTableButton_Click(object sender, EventArgs e)
        {
            owt.LoadTable();
        }

        private void InsertContractButton_Click(object sender, EventArgs e)
        {
            InsertContractForm insertForm = new InsertContractForm();
            insertForm.Show();
        }

        private void UpdateInfoButton_Click(object sender, EventArgs e)
        {
            UpdateInfoForm updateInfoForm = new UpdateInfoForm();
            updateInfoForm.Show();
        }

        private void DeleteContractButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить этот договор?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            == DialogResult.Yes)
            {
                owc.DeleteContracts();
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            cf.Search();
        }

        private void DatePeriodFilter_Click(object sender, EventArgs e)
        {
            cf.DatePeriodFilter();
        }

        private void DateFilter_Click(object sender, EventArgs e)
        {
            cf.DateFilter();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime d1 = dateTimePicker1.Value.Date;
            date1TextBox.Text = d1.ToString("MM.dd.yyyy");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime d2 = dateTimePicker2.Value.Date;
            date2TextBox.Text = d2.ToString("MM.dd.yyyy");
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            DateTime d3 = dateTimePicker3.Value.Date;
            date3TextBox.Text = d3.ToString("MM.dd.yyyy");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdTextBoxMain.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }
    }
}