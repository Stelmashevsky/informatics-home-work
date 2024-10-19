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
    public partial class ConsultForm : Form
    {
        public ConsultForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataBaseForm f = new DataBaseForm();
            f.Show();
        }
    }
}
