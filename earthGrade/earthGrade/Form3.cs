﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Text;

namespace earthGrade
{
    public partial class Form3 : Form
    {
        private SqlConnection conn = new SqlConnection("server=192.168.134.19;database=EarthGrade;User Id=sqluser;Password=Patat2024");

        //static void Main(string[] args)
        //{
        //    string insertQuery = "INSERT INTO dbo.Studeren ([Studeer tijd], Pauze, Sessies) VALUES (@minutes, @studyBreak, @session)";

        //    using (SqlCommand command = new SqlCommand(insertQuery, conn))
        //    {
        //        command.Parameters.AddWithValue("@minutes", minutes); // Voert het variable in het kolommen

        //        int rowsAffected = command.ExecuteNonQuery();

        //        if (rowsAffected > 0)
        //        {
        //            Console.WriteLine("Data inserted successfully!");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Failed to insert data.");
        //        }
        //    }
        //}
        public Form3()
        {
            InitializeComponent();
        }
        public class user
        {
            private int userid;
            private string gebruikersnaam;
            private string password;
            private string email;

            public user(int userid, string gebruikersnaam, string password, string email)
            {
                this.userid = userid;
                this.gebruikersnaam = gebruikersnaam;
                this.password = password;
                this.email = email;
            }

        }
        
        int userid = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            userid++;
            user test = new user(userid, createUsername.Text, createPassword.Text, createEmail.Text);
            testLabel.Text = userid.ToString();
        }
        
        

        private void button2_Click(object sender, EventArgs e)
        {
            var form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}