﻿namespace earthGrade
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label1 = new Label();
            createEmail = new TextBox();
            label2 = new Label();
            createUsername = new TextBox();
            label3 = new Label();
            label4 = new Label();
            createPassword = new TextBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(102, 45);
            label1.Name = "label1";
            label1.Size = new Size(185, 32);
            label1.TabIndex = 0;
            label1.Text = "Create account";
            // 
            // createEmail
            // 
            createEmail.BackColor = SystemColors.ControlLight;
            createEmail.BorderStyle = BorderStyle.FixedSingle;
            createEmail.Location = new Point(86, 129);
            createEmail.Margin = new Padding(3, 2, 3, 2);
            createEmail.Name = "createEmail";
            createEmail.Size = new Size(231, 23);
            createEmail.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(86, 107);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 2;
            label2.Text = "Email adress";
            label2.Click += label2_Click;
            // 
            // createUsername
            // 
            createUsername.BackColor = SystemColors.ControlLight;
            createUsername.BorderStyle = BorderStyle.FixedSingle;
            createUsername.Location = new Point(86, 178);
            createUsername.Margin = new Padding(3, 2, 3, 2);
            createUsername.Name = "createUsername";
            createUsername.Size = new Size(231, 23);
            createUsername.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(86, 156);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 4;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(86, 215);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // createPassword
            // 
            createPassword.BackColor = SystemColors.ControlLight;
            createPassword.BorderStyle = BorderStyle.FixedSingle;
            createPassword.Location = new Point(86, 237);
            createPassword.Margin = new Padding(3, 2, 3, 2);
            createPassword.Name = "createPassword";
            createPassword.PasswordChar = '*';
            createPassword.Size = new Size(231, 23);
            createPassword.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(131, 312);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(135, 44);
            button1.TabIndex = 7;
            button1.Text = "Create account";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGray;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(232, 268);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(85, 23);
            button2.TabIndex = 9;
            button2.Text = "Back to login";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(108, 360);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(86, 272);
            label5.Name = "label5";
            label5.Size = new Size(140, 15);
            label5.TabIndex = 11;
            label5.Text = "already have an account?";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(63, 126, 68);
            ClientSize = new Size(404, 562);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(createPassword);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(createUsername);
            Controls.Add(createEmail);
            Controls.Add(label1);
            Controls.Add(label2);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form3";
            Text = "EarthGrade";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox createEmail;
        private Label label2;
        private TextBox createUsername;
        private Label label3;
        private Label label4;
        private TextBox createPassword;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private Label label5;
    }
}