namespace earthGrade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public class user
        {
            private int userid;
            private string password;
            private string email;

            public user(int userid, string password, string email)
            {
                this.userid = userid++;
                this.password = password;
                this.email = email;
            }

            static void Main(string[] args)
            {
                
            }
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
    }
}