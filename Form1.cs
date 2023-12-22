namespace earthGrade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string text = emailBox.Text;
            if (text == "email" && passwordBox.Text == "password")
            {
                var form2 = new Form2();
                this.Hide();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Email or password incorrect");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form3 = new Form3();
            this.Hide();
            form3.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}