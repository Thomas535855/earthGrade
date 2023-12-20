namespace earthGrade
{
    partial class home
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
            panel1 = new Panel();
            button2 = new Button();
            label1 = new Label();
            button1 = new Button();
            logoutButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(logoutButton);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(0, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(463, 85);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(320, 16);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(130, 43);
            button2.TabIndex = 3;
            button2.Text = "My Profile";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 102);
            label1.Name = "label1";
            label1.Size = new Size(167, 20);
            label1.TabIndex = 1;
            label1.Text = "Welcome to earthGrade";
            // 
            // button1
            // 
            button1.Location = new Point(99, 177);
            button1.Name = "button1";
            button1.Size = new Size(259, 128);
            button1.TabIndex = 2;
            button1.Text = "Scan a product";
            button1.UseVisualStyleBackColor = true;
            // 
            // logoutButton
            // 
            logoutButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            logoutButton.Location = new Point(12, 16);
            logoutButton.Margin = new Padding(3, 4, 3, 4);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(87, 43);
            logoutButton.TabIndex = 4;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 753);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button logoutButton;
    }
}