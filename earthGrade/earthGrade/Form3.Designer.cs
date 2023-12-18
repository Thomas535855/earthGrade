namespace earthGrade
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(116, 60);
            label1.Name = "label1";
            label1.Size = new Size(227, 41);
            label1.TabIndex = 0;
            label1.Text = "Create account";
            // 
            // createEmail
            // 
            createEmail.BackColor = SystemColors.ControlLight;
            createEmail.BorderStyle = BorderStyle.FixedSingle;
            createEmail.Location = new Point(116, 171);
            createEmail.Name = "createEmail";
            createEmail.Size = new Size(227, 27);
            createEmail.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(111, 143);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 2;
            label2.Text = "Email adress";
            label2.Click += label2_Click;
            // 
            // createUsername
            // 
            createUsername.BackColor = SystemColors.ControlLight;
            createUsername.BorderStyle = BorderStyle.FixedSingle;
            createUsername.Location = new Point(116, 238);
            createUsername.Name = "createUsername";
            createUsername.Size = new Size(227, 27);
            createUsername.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(111, 210);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 4;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(112, 288);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // createPassword
            // 
            createPassword.BackColor = SystemColors.ControlLight;
            createPassword.BorderStyle = BorderStyle.FixedSingle;
            createPassword.Location = new Point(116, 316);
            createPassword.Name = "createPassword";
            createPassword.PasswordChar = '*';
            createPassword.Size = new Size(227, 27);
            createPassword.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(157, 385);
            button1.Name = "button1";
            button1.Size = new Size(154, 59);
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
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(66, 43);
            button2.TabIndex = 9;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(123, 480);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 205);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(63, 126, 68);
            ClientSize = new Size(462, 753);
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
    }
}