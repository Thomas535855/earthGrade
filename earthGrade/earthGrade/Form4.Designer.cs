namespace earthGrade
{
    partial class Form4
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
            panel2 = new Panel();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(339, 63);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Location = new Point(1, 448);
            panel2.Name = "panel2";
            panel2.Size = new Size(339, 63);
            panel2.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(11, 13);
            button1.Name = "button1";
            button1.Size = new Size(75, 37);
            button1.TabIndex = 0;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(130, 18);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 1;
            label1.Text = "My Profile";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(263, 92);
            label2.Name = "label2";
            label2.Size = new Size(23, 25);
            label2.TabIndex = 1;
            label2.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(51, 92);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 2;
            label3.Text = "My Points";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(51, 195);
            label4.Name = "label4";
            label4.Size = new Size(165, 25);
            label4.TabIndex = 3;
            label4.Text = "Recently scanned";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(51, 314);
            label5.Name = "label5";
            label5.Size = new Size(140, 25);
            label5.TabIndex = 4;
            label5.Text = "Possible prizes";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 511);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form4";
            Text = "Form4";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}