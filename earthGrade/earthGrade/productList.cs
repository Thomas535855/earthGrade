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
            product appelNL = new product(1, "appelNL", "1234", 4.5);
            product appelVS = new product(2, "appelVS", "9876", 2.3);

            label1.Text = appelNL.name;
            label2.Text = appelVS.name;

            infoBox1.Items.Add(appelNL.sterren);
            infoBox1.Items.Add(appelNL.code);
            infoBox1.Items.Add(appelNL.id);

            infoBox2.Items.Add(appelVS.sterren);
            infoBox2.Items.Add(appelVS.code);
            infoBox2.Items.Add(appelVS.id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (infoBox1.Visible == false)
            {
                infoBox1.Visible = true;
                infoButton1.Text = "Show less";
            }
            else
            {
                infoBox1.Visible = false;
                infoButton1.Text = "More info";
            }


        }

        private void infoButton2_Click(object sender, EventArgs e)
        {
            if (infoBox2.Visible == false)
            {
                infoBox2.Visible = true;
                infoButton2.Text = "Show less";
            }
            else
            {
                infoBox2.Visible = false;
                infoButton2.Text = "More info";
            }
        }
    }
}
