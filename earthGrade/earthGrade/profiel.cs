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
    public partial class profiel : Form
    {
        public profiel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            home form2 = new home();
            this.Hide();
            form2.Show();

        }
    }
}
