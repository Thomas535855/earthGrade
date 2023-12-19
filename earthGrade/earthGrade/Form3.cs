using System.Data.SqlClient;

namespace earthGrade
{
    public partial class Form3 : Form
    {
        private SqlConnection conn = new SqlConnection("server=192.168.134.19;database=EarthGrade;User Id=sqluser;Password=Patat2024");

        public class user
        {
            public int userid;
            public string gebruikersnaam;
            public string password;
            public string email;

            public user(int userid, string gebruikersnaam, string password, string email)
            {
                this.userid = userid;
                this.gebruikersnaam = gebruikersnaam;
                this.password = password;
                this.email = email;
            }

        }

        int userid = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (createEmail.Text.Length > 0
                && createUsername.Text.Length > 0
                && createPassword.Text.Length > 3)
            {
                userid++;
                user test = new user(userid, createUsername.Text, createPassword.Text, createEmail.Text);

                // Open the database connection
                conn.Open();

                // SQL query to insert user data into the 'users' table assuming the table columns are 'userid', 'gebruikersnaam', 'password', 'email'
                string insertQuery = "INSERT INTO users (userid, gebruikersnaam, password, email) VALUES (@UserId, @Username, @Password, @Email)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    // Add parameters to the SQL query
                    cmd.Parameters.AddWithValue("@UserId", test.userid);
                    cmd.Parameters.AddWithValue("@Username", test.gebruikersnaam);
                    cmd.Parameters.AddWithValue("@Password", test.password);
                    cmd.Parameters.AddWithValue("@Email", test.email);

                    // Execute the SQL command
                    cmd.ExecuteNonQuery();
                }

                // Close the database connection
                conn.Close();

                createEmail.Text = "";
                createUsername.Text = "";
                createPassword.Text = "";
                MessageBox.Show("Account successfully created! userid: " + userid);
            }
            else if (createPassword.Text.Length <= 3)
            {
                MessageBox.Show("Password must be longer than 3 characters");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
