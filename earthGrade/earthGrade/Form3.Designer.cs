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
            label1 = new Label();
            createEmail = new TextBox();
            label2 = new Label();
            createUsername = new TextBox();
            label3 = new Label();
            label4 = new Label();
            createPassword = new TextBox();
            button1 = new Button();
            testLabel = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(157, 85);
            label1.Name = "label1";
            label1.Size = new Size(167, 31);
            label1.TabIndex = 0;
            label1.Text = "Create account";
            // 
            // createEmail
            // 
            createEmail.Location = new Point(116, 171);
            createEmail.Name = "createEmail";
            createEmail.Size = new Size(227, 27);
            createEmail.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 148);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 2;
            label2.Text = "email";
            // 
            // createUsername
            // 
            createUsername.Location = new Point(116, 238);
            createUsername.Name = "createUsername";
            createUsername.Size = new Size(227, 27);
            createUsername.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(116, 215);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 4;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(116, 293);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // createPassword
            // 
            createPassword.Location = new Point(116, 316);
            createPassword.Name = "createPassword";
            createPassword.PasswordChar = '*';
            createPassword.Size = new Size(227, 27);
            createPassword.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(157, 385);
            button1.Name = "button1";
            button1.Size = new Size(154, 59);
            button1.TabIndex = 7;
            button1.Text = "Create account";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // testLabel
            // 
            testLabel.AutoSize = true;
            testLabel.Location = new Point(246, 520);
            testLabel.Name = "testLabel";
            testLabel.Size = new Size(33, 20);
            testLabel.TabIndex = 8;
            testLabel.Text = "test";
            // 
            // button2
            // 
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(52, 43);
            button2.TabIndex = 9;
            button2.Text = "back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 753);
            Controls.Add(button2);
            Controls.Add(testLabel);
            Controls.Add(button1);
            Controls.Add(createPassword);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(createUsername);
            Controls.Add(createEmail);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Form3";
            Text = "Form3";
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
        private Label testLabel;
        private Button button2;
    }
}