using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlServerCe;

namespace KURSACH
{
    public partial class InsertContractForm : Form
    {
        private SqlCeCommand cmd;
        private static string c = (@"Data Source=..\Debug\ContractsDataBase.sdf");
        private SqlCeConnection con = new SqlCeConnection(c);

        public InsertContractForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(textBox1.Text) | String.IsNullOrWhiteSpace(comboBox2.Text) | String.IsNullOrWhiteSpace(comboBox3.Text) |
                String.IsNullOrWhiteSpace(textBox4.Text) | String.IsNullOrWhiteSpace(dateTimePicker5.Text) | String.IsNullOrWhiteSpace(dateTimePicker6.Text) |
                String.IsNullOrWhiteSpace(textBox7.Text) | String.IsNullOrWhiteSpace(textBox8.Text))
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                con.Open();
                SqlCeCommand cmd = new SqlCeCommand("INSERT INTO Contracts (Номер, Состояние, Вид, Контрагент, Начало, Окончание, Предмет, Сумма)" +
                " VALUES('" + textBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + textBox4.Text + "'," +
                "'" + date1TextBox.Text + "','" + date2TextBox.Text + "','" + textBox7.Text + "','" + textBox8.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                this.Close();
                MessageBox.Show("Договор успешно добавлен!");
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if(!Char.IsDigit(ch) && ch != 8 && ch != 232 && ch != '.' && ch != ',')
            {
                e.Handled = true;
            }
        }

        private void dateTimePicker5_ValueChanged(object sender, EventArgs e)
        {
            DateTime d1 = dateTimePicker5.Value.Date;
            date1TextBox.Text = d1.ToString("MM.dd.yyyy");
        }

        private void dateTimePicker6_ValueChanged(object sender, EventArgs e)
        {
            DateTime d2 = dateTimePicker6.Value.Date;
            date2TextBox.Text = d2.ToString("MM.dd.yyyy");
        }
    }
}
