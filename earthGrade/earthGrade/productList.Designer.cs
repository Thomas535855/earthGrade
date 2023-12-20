namespace earthGrade
{
    partial class productList
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
            button1 = new Button();
            infoBox1 = new ListBox();
            label1 = new Label();
            infoButton1 = new Button();
            infoButton2 = new Button();
            label2 = new Label();
            infoBox2 = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 84);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(13, 17);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 49);
            button1.TabIndex = 0;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // infoBox1
            // 
            infoBox1.FormattingEnabled = true;
            infoBox1.ItemHeight = 20;
            infoBox1.Location = new Point(13, 139);
            infoBox1.Name = "infoBox1";
            infoBox1.Size = new Size(129, 144);
            infoBox1.TabIndex = 2;
            infoBox1.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 108);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 3;
            label1.Text = "Product1";
            // 
            // infoButton1
            // 
            infoButton1.Location = new Point(86, 104);
            infoButton1.Name = "infoButton1";
            infoButton1.Size = new Size(94, 29);
            infoButton1.TabIndex = 4;
            infoButton1.Text = "More info";
            infoButton1.UseVisualStyleBackColor = true;
            infoButton1.Click += button2_Click;
            // 
            // infoButton2
            // 
            infoButton2.Location = new Point(86, 316);
            infoButton2.Name = "infoButton2";
            infoButton2.Size = new Size(94, 29);
            infoButton2.TabIndex = 7;
            infoButton2.Text = "More info";
            infoButton2.UseVisualStyleBackColor = true;
            infoButton2.Click += infoButton2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 320);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 6;
            label2.Text = "Product1";
            // 
            // infoBox2
            // 
            infoBox2.FormattingEnabled = true;
            infoBox2.ItemHeight = 20;
            infoBox2.Location = new Point(13, 351);
            infoBox2.Name = "infoBox2";
            infoBox2.Size = new Size(129, 144);
            infoBox2.TabIndex = 5;
            infoBox2.Visible = false;
            // 
            // productList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 753);
            Controls.Add(infoButton2);
            Controls.Add(label2);
            Controls.Add(infoBox2);
            Controls.Add(infoButton1);
            Controls.Add(label1);
            Controls.Add(infoBox1);
            Controls.Add(panel1);
            Name = "productList";
            Text = "productList";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private ListBox infoBox1;
        private Label label1;
        private Button infoButton1;
        private Button infoButton2;
        private Label label2;
        private ListBox infoBox2;
    }
}