using System;
//using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ScamBank_infa_dz
{
    public partial class WelcomeForm : Form
    {
        //private const string UsersFilePath = "users.txt";
        //private const string LoginsFilePath = "logins.txt";

        public WelcomeForm()
        {
            InitializeComponent();
        }    

        private void button2_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            if (txtUserName.Text == "consult" & txtPassword.Text == "11")
            {
                //UpdateLoginStatus(username, true);
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();
                this.Hide();
                ConsultForm f = new ConsultForm();
                f.Show();
            }
            if (txtUserName.Text == "manager" & txtPassword.Text == "22")
            {
                //UpdateLoginStatus(username, true);
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();
                this.Hide();
                ManagerForm f = new ManagerForm();
                f.Show();
            }
            if (txtUserName.Text == "smanager" & txtPassword.Text == "33")
            {
                //UpdateLoginStatus(username, true);
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();
                this.Hide();
                sManagerForm f = new sManagerForm();
                f.Show();
            }
        }

        //private void UpdateLoginStatus(string username, bool isLoggedIn)
        //{
        //    string[] lines = File.ReadAllLines(UsersFilePath);

        //    for (int i = 0; i < lines.Length; i++)
        //    {
        //        string[] parts = lines[i].Split(',');

        //        if (parts.Length == 2 && parts[0] == username)
        //        {
        //            lines[i] = $"{username},{isLoggedIn}";
        //            break;
        //        }
        //    }
        //    File.WriteAllLines(LoginsFilePath, lines);
        //}

        //private bool ValidateLogin(string username, string password)
        //{
        //    string[] lines = File.ReadAllLines(UsersFilePath);

        //    foreach(string line in lines)
        //    {
        //        string[] parts = line.Split(',');

        //        if (parts.Length == 2 && parts[0] == username && parts[1] == password)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        
        private void label1_Click(object sender, EventArgs e)
            {

            }

        private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }

        private void textBox2_TextChanged(object sender, EventArgs e)
            {

            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

