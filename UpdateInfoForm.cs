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
    public partial class UpdateInfoForm : Form
    {
        private SqlCeCommand cmd;
        private static string c = (@"Data Source=..\Debug\ContractsDataBase.sdf");
        private SqlCeConnection con = new SqlCeConnection(c);

        public UpdateInfoForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text) | String.IsNullOrWhiteSpace(comboBox2.Text) | String.IsNullOrWhiteSpace(comboBox3.Text) |
                String.IsNullOrWhiteSpace(textBox4.Text) | String.IsNullOrWhiteSpace(dateTimePicker5.Text) | String.IsNullOrWhiteSpace(dateTimePicker6.Text) |
                String.IsNullOrWhiteSpace(textBox7.Text) | String.IsNullOrWhiteSpace(textBox8.Text))
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                con.Open();
                SqlCeCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Contracts SET Номер ='" + textBox1.Text + "',Состояние ='" + comboBox2.Text + "',Вид ='" + comboBox3.Text + "'," +
                    "Контрагент ='" + textBox4.Text + "',Начало =" + "'" + date1TextBox.Text + "',Окончание ='" + date2TextBox.Text + "'," +
                    "Предмет ='" + textBox7.Text + "',Сумма ='" + textBox8.Text + "' WHERE Id = '" + IDtextBox.Text + "' ";
                cmd.ExecuteNonQuery();
                con.Close();
                this.Close();
                MessageBox.Show("Договор успешно изменён!");
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 232 && ch != '.' && ch != ',')
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
