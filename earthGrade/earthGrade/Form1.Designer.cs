namespace earthGrade
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            emailBox = new TextBox();
            passwordBox = new TextBox();
            loginButton = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // emailBox
            // 
            emailBox.Location = new Point(120, 257);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(244, 27);
            emailBox.TabIndex = 0;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(120, 322);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.Size = new Size(244, 27);
            passwordBox.TabIndex = 1;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(143, 383);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(170, 65);
            loginButton.TabIndex = 2;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(120, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 205);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(53, 254);
            label1.Name = "label1";
            label1.Size = new Size(69, 28);
            label1.TabIndex = 4;
            label1.Text = "Email:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(16, 320);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 5;
            label2.Text = "Password:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(63, 126, 68);
            ClientSize = new Size(462, 753);
            Controls.Add(pictureBox1);
            Controls.Add(loginButton);
            Controls.Add(passwordBox);
            Controls.Add(emailBox);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox emailBox;
        private TextBox passwordBox;
        private Button loginButton;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}