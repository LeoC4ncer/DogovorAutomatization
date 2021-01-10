using System;
using System.Data;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace KURSACH
{
    public class OperationWithTable
    {
        public static MainForm mf = new MainForm();
        public static InsertContractForm icf = new InsertContractForm();
        public static UpdateInfoForm uif = new UpdateInfoForm();

        public SqlCeConnection con = new SqlCeConnection(@"Data Source=ContractsDataBase.sdf");

        public (int, string) LoadTable()
        {
            con.Open();
            SqlCeCommand cmd = new SqlCeCommand("SELECT * FROM Contracts", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            da.Fill(dt);
            mf.dataGridView1.DataSource = dt;
            con.Close();
            mf.dataGridView1.Columns[0].Visible = false;
            ReloadMainForm();
            int Item1 = Convert.ToInt32(mf.dataGridView1[8, 0].Value);
            string Item2 = mf.dataGridView1[1, 0].Value.ToString();
            return (Item1, Item2);
        }

        public void ReloadMainForm()
        {
            mf.dateTimePicker1.Value = DateTime.Today;
            mf.dateTimePicker2.Value = DateTime.Today;
            mf.dateTimePicker3.Value = DateTime.Today;
        }
    }

    public class OperationWithContracts : OperationWithTable
    {
        public void InsertContract()
        {
            con.Open();
            SqlCeCommand cmd = new SqlCeCommand("INSERT INTO Contracts (Номер, Состояние, Вид, Контрагент, Начало, Окончание, Предмет, Сумма)" +
            " VALUES('" + icf.textBox1.Text + "','" + icf.comboBox2.Text + "','" + icf.comboBox3.Text + "','" + icf.textBox4.Text + "'," +
            "'" + icf.date1TextBox.Text + "','" + icf.date2TextBox.Text + "','" + icf.textBox7.Text + "','" + icf.textBox8.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            icf.Close();
            LoadTable();
            MessageBox.Show("Договор успешно добавлен!");
        }

        public void UpdateInfoFormOpen()
        {
            uif.IDtextBox.Text = mf.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            uif.textBox1.Text = mf.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            uif.comboBox2.Text = mf.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            uif.comboBox3.Text = mf.dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            uif.textBox4.Text = mf.dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            uif.dateTimePicker5.Text = mf.dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            uif.dateTimePicker6.Text = mf.dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            uif.textBox7.Text = mf.dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            uif.textBox8.Text = mf.dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            uif.Show();
        }

        public void UpdateContract()
        {
            con.Open();
            SqlCeCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Contracts SET Номер ='" + uif.textBox1.Text + "',Состояние ='" + uif.comboBox2.Text + "',Вид ='" + uif.comboBox3.Text + "'," +
                "Контрагент ='" + uif.textBox4.Text + "',Начало =" + "'" + uif.date1TextBox.Text + "',Окончание ='" + uif.date2TextBox.Text + "'," +
                "Предмет ='" + uif.textBox7.Text + "',Сумма ='" + uif.textBox8.Text + "' WHERE Id = '" + uif.IDtextBox.Text + "' ";
            cmd.ExecuteNonQuery();
            con.Close();
            uif.Close();
            LoadTable();
            MessageBox.Show("Договор успешно изменён!");
        }

        public void DeleteContracts()
        {
            con.Open();
            int ID = Convert.ToInt32(mf.IdTextBoxMain.Text);
            SqlCeCommand cmd = new SqlCeCommand("DELETE  FROM Contracts WHERE Id = '" + ID + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            LoadTable();
            MessageBox.Show("Договор успешно удалён!");
        }
    }

    public class ContractFilters : OperationWithTable
    {
        public void DatePeriodFilter()
        {
            con.Open();
            SqlCeCommand com = new SqlCeCommand("SELECT * FROM Contracts WHERE Начало BETWEEN '" + mf.date2TextBox.Text + "' AND '" + mf.date3TextBox.Text + "'" +
                " UNION SELECT * FROM Contracts WHERE Окончание BETWEEN '" + mf.date2TextBox.Text + "' AND '" + mf.date3TextBox.Text + "'", con);
            DataTable dt = new DataTable();
            dt.Load(com.ExecuteReader());
            con.Close();
            mf.dataGridView1.DataSource = dt.DefaultView;
        }

        public void DateFilter()
        {
            con.Open();
            SqlCeCommand com = new SqlCeCommand("SELECT * FROM Contracts WHERE '" + mf.date1TextBox.Text + "' BETWEEN Начало AND Окончание", con);
            DataTable dt = new DataTable();
            dt.Load(com.ExecuteReader());
            con.Close();
            mf.dataGridView1.DataSource = dt.DefaultView;
        }

        public void Search()
        {
            con.Open();
            SqlCeCommand com = new SqlCeCommand("SELECT * FROM Contracts WHERE Номер like '%" + mf.textBoxSearch.Text + "%'" +
                " or Состояние like '%" + mf.textBoxSearch.Text + "%' or Вид like '%" + mf.textBoxSearch.Text + "%' or Контрагент like '%" + mf.textBoxSearch.Text + "%'" +
                " or Предмет like '%" + mf.textBoxSearch.Text + "%' or Сумма like '%" + mf.textBoxSearch.Text + "%'", con);
            DataTable dt = new DataTable();
            dt.Load(com.ExecuteReader());
            con.Close();
            mf.dataGridView1.DataSource = dt.DefaultView;
        }
    }
}