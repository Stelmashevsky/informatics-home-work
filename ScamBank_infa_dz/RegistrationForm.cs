using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace ScamBank_infa_dz
{
    public partial class RegistrationForm : Form
    {
        string sn;
        string fn;
        string ln;
        double pn;
        double passSer;
        double passNum;
        double cn;

        List<Client> Client_list = new List<Client>();

        public RegistrationForm()
        {
            InitializeComponent();
        }
        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            Phone.KeyPress += Phone_KeyPress;
            PassportSeries.KeyPress += Phone_KeyPress;
            PassportNumber.KeyPress += Phone_KeyPress;
            CardNumber.KeyPress += Phone_KeyPress;

            Phone.TextChanged += Phone_TextChanged;
            PassportSeries.TextChanged += PassportSeries_TextChanged;
            PassportNumber.TextChanged += PassportNumber_TextChanged;
            CardNumber.TextChanged += CardNumber_TextChanged;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void SecondName_TextChanged(object sender, EventArgs e)
        {

        }

        private void FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != '+')
            {
                e.Handled = true;
            }

        }

        private void PassportSeries_TextChanged(object sender, EventArgs e)
        {

        }
        private void PassportSeries_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Если нажатый символ не является цифрой и не символом '+', отменяем ввод
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch))
            {
                e.Handled = true;
            }

        }
        private void PassportNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void PassportNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch))
            {
                e.Handled = true;
            }

        }

        private void CardNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void CardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch))
            {
                e.Handled = true;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e) //save button function
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.GetType() == typeof(System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox))
                    if ((String)ctrl.Text == "") MessageBox.Show("Заполнены не все поля");
            }
            Client s = new Client(sn, fn, ln, pn, passSer, passNum, cn);

            MessageBox.Show(s.Info());

            StreamWriter streamwriter = new StreamWriter(@"C:\Database\Database.txt", true, System.Text.Encoding.GetEncoding("utf-8"));
            streamwriter.WriteLine(s.Info());
            streamwriter.Close();
        }

        private bool CheckField()
        {
            if (SecondName.Text != String.Empty)
            {
                ln = SecondName.Text;
            }
            else
            {
                MessageBox.Show("Заполните поле Фамилия");
                SecondName.Focus();
                return false;
            }
            if (FirstName.Text != String.Empty)
            {
                fn = FirstName.Text;
            }
            else
            {
                FirstName.Focus();
                MessageBox.Show("Заполните поле Имя");
                return false;
            }
            if (Phone.Text != String.Empty)
            {
                pn = Convert.ToDouble(Phone.Text.Replace(',', '.'));
            }
            else
            {
                Phone.Focus();
                MessageBox.Show("Заполните поле телефон");
                return false;
            }
            if (PassportSeries.Text != String.Empty)
            {
                passSer = Convert.ToDouble(PassportSeries.Text.Replace(',', '.'));
            }
            else
            {
                PassportSeries.Focus();
                MessageBox.Show("Заполните поле серия паспорта");
                return false;
            }
            if (PassportNumber.Text != String.Empty)
            {
                passNum = Convert.ToDouble(PassportNumber.Text.Replace(',', '.'));
            }
            else
            {
                PassportNumber.Focus();
                MessageBox.Show("Заполните поле номер паспорта");
                return false;
            }
            return true;
        }

        private void DatabaseButton_Click_1(object sender, EventArgs e) // database open button function
        {
            if (CheckField())
            {
                Client s = new Client(sn, fn, ln, pn, passSer, passNum, cn);

                Client_list.Add(s);
                Client_list.Sort();

                string message = "";    

                foreach (var x in Client_list) message += x.Info() + "\n";
                MessageBox.Show(message);

                string path = @"C:\Database";
                DirectoryInfo dirInfo = new DirectoryInfo(path);
                if (!dirInfo.Exists)
                {
                    dirInfo.Create();
                    MessageBox.Show(@"Create dir C:\Database");
                }
                StreamWriter file = new StreamWriter(@"C:\Database\Database.txt", true);
                foreach (var x in Client_list)
                    file.WriteLine(x.Info());
                file.Close();
            }
            if (File.Exists(@"C:\Database\Database.txt"))
            {
                DataBaseForm f = new DataBaseForm();
                f.Show();
            }
            else
            {
                MessageBox.Show("Файла нет");
                return;
            }
        }
    }
}
