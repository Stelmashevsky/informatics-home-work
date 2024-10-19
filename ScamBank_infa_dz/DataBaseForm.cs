using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScamBank_infa_dz
{
    public partial class DataBaseForm : Form
    {
        DataTable dt;
        List<Client> Client_list;

        public DataBaseForm()
        {
            InitializeComponent();
        }

        private void DataBaseForm_Load(object sender, EventArgs e)
        {
            dt = new DataTable();

            dt.Columns.Add("Фамилия");
            dt.Columns.Add("Имя");
            dt.Columns.Add("Отчество");
            dt.Columns.Add("Номер тел.");
            dt.Columns.Add("Серия пасп.");
            dt.Columns.Add("Номер пасп.");
            dt.Columns.Add("Номер банк. карты");

            string filename = @"C:\Database\Database.txt";

            if (File.Exists(filename))
            {
                StreamReader file = new StreamReader(filename);
                string[] values;
                string newline;

                while ((newline = file.ReadLine()) != null)
                {
                    DataRow dr = dt.NewRow();

                    values = newline.Split(' ');

                    for (int i = 0; i < values.Length; i++)
                    {
                        dr[i] = values[i];
                    }

                    dt.Rows.Add(dr);
                }
                file.Close();

                dataGridView1.DataSource = dt;

                dataGridView1.AutoResizeColumns();
            }
            else MessageBox.Show("Нет файла с данными");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }
    }
}
