namespace earthGrade
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        public class product
        {
            private int productid;
            private string name;
            private int rating;
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            string text = emailBox.Text;
            if (text == "email" && passwordBox.Text == "password")
            {
                var form2 = new home();
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
            var form3 = new registreer();
            this.Hide();
            form3.Show();
        }
    }
}