using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace KURSACH
{
    public partial class MainForm : Form
    {
        private SqlCeCommand cmd;
        private static string c = (@"Data Source=..\Debug\ContractsDataBase.sdf");
        SqlCeConnection con = new SqlCeConnection(c);
        public MainForm()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            con.Open();
            SqlCeCommand cmd = new SqlCeCommand("SELECT * FROM Contracts", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            con.Close();
            dateTimePicker1.Value = new DateTime(2000, 01, 01);
            dateTimePicker2.Value = new DateTime(2000, 01, 01);
            dateTimePicker3.Value = new DateTime(2000, 01, 01);
            textBoxSearch.Clear();
        }

        public void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void InsertContractButton_Click(object sender, EventArgs e)
        {
            InsertContractForm insertForm = new InsertContractForm();
            insertForm.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void ReloadTableButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void DeleteContractButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ДЕМО: Удалить этот договор??", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            == DialogResult.Yes)
            {
                con.Open();
                IdTextBoxMain.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                int ID = Convert.ToInt32(IdTextBoxMain.Text);
                SqlCeCommand cmd = new SqlCeCommand("DELETE  FROM Contracts WHERE Id = '" + ID + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                LoadData();
                MessageBox.Show("Договор удалён успешно!");
            }
        }

        private void DatePeriodFilter_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCeCommand com = new SqlCeCommand("SELECT * FROM Contracts WHERE Начало BETWEEN '" + dateTimePicker2.Text + "' AND '" + dateTimePicker3.Text + "' UNION SELECT * FROM Contracts WHERE Окончание BETWEEN '" + dateTimePicker2.Text + "' AND '" + dateTimePicker3.Text + "'", con);
            DataTable dt = new DataTable();
            dt.Load(com.ExecuteReader());
            con.Close();
            dataGridView1.DataSource = dt.DefaultView;
        }

        private void DateFilter_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCeCommand com = new SqlCeCommand("SELECT * FROM Contracts WHERE '" + dateTimePicker1.Value.Date + "' BETWEEN Начало AND Окончание", con);
            DataTable dt = new DataTable();
            dt.Load(com.ExecuteReader());
            con.Close();
            dataGridView1.DataSource = dt.DefaultView;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCeCommand com = new SqlCeCommand("SELECT * FROM Contracts WHERE Номер like '%" + textBoxSearch.Text + "%'" +
                " or Состояние like '%" + textBoxSearch.Text + "%' or Вид like '%" + textBoxSearch.Text + "%' or Контрагент like '%" + textBoxSearch.Text + "%'" +
                " or Предмет like '%" + textBoxSearch.Text + "%' or Сумма like '%" + textBoxSearch.Text + "%'", con);
            DataTable dt = new DataTable();
            dt.Load(com.ExecuteReader());
            con.Close();
            dataGridView1.DataSource = dt.DefaultView;
        }

        private void UpdateInfoButton_Click(object sender, EventArgs e)
        {
            UpdateInfoForm uif = new UpdateInfoForm();

            uif.IDtextBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            uif.textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            uif.comboBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            uif.comboBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            uif.textBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            uif.dateTimePicker5.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            uif.dateTimePicker6.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            uif.textBox7.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            uif.textBox8.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            uif.Show();
        }
    }
}