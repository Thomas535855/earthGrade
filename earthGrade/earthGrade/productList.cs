using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace earthGrade
{
    public partial class productList : Form
    {



        public productList()
        {
            InitializeComponent();

            List<product> productList = new List<product>();

            productList.Add(new product(1, "Product 1", "Code1", 2.5));
            productList.Add(new product(2, "Product 2", "Code1", 4.5));
            productList.Add(new product(3, "Product 3", "Code1", 1.2));

            dataGridView1.DataSource = productList;
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["code"].Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            this.Hide();
            form2.Show();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dataGridView1.Columns["id"].Visible = true;
                dataGridView1.Columns["code"].Visible = true;
            }
            else
            {
                dataGridView1.Columns["id"].Visible = false;
                dataGridView1.Columns["code"].Visible = false;
            }

        }
    }
}
