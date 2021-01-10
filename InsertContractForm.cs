using System;
using System.Windows.Forms;

namespace KURSACH
{
    public partial class InsertContractForm : Form
    {
        OperationWithContracts owc = new OperationWithContracts();

        public InsertContractForm()
        {
            OperationWithContracts.icf = this;
            InitializeComponent();
        }

        private void InsertContractForm_Load(object sender, EventArgs e)
        {
            date1TextBox.Text = DateTime.Today.ToString("MM.dd.yyyy");
            date2TextBox.Text = DateTime.Today.ToString("MM.dd.yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(textBox1.Text) | String.IsNullOrWhiteSpace(comboBox2.Text) | String.IsNullOrWhiteSpace(comboBox3.Text) |
                String.IsNullOrWhiteSpace(textBox4.Text) | String.IsNullOrWhiteSpace(dateTimePicker5.Text) | String.IsNullOrWhiteSpace(dateTimePicker6.Text) |
                String.IsNullOrWhiteSpace(textBox7.Text) | String.IsNullOrWhiteSpace(textBox8.Text))
            {
                MessageBox.Show("Заполните все поля!");
            }
            else if (dateTimePicker5.Value > dateTimePicker6.Value)
            {
                MessageBox.Show("Дата начала действия договора не может быть позже даты конца действия договора!");
            }
            else if (Convert.ToInt32(textBox8.Text) == 0)
            {
                MessageBox.Show("Сумма не может быть равна нулю!");
            }
            else
            {
                owc.InsertContract();
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 232 && ch != '.')
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
