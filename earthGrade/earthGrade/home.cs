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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            profiel form4 = new profiel();
            this.Hide();
            form4.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            login form1 = new login();
            this.Hide();
            form1.Show();
        }
    }
}
