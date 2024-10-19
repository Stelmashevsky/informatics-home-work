using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScamBank_infa_dz
{

    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm f = new RegistrationForm();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataBaseForm f = new DataBaseForm();
            f.Show();
        }
    }
}
