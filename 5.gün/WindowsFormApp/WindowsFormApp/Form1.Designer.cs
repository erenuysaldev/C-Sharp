namespace WindowsFormApp
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
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button3 = new Button();
            textBox1 = new TextBox();
            button4 = new Button();
            label9 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Palatino Linotype", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(-4, 162);
            button1.Name = "button1";
            button1.Size = new Size(267, 57);
            button1.TabIndex = 0;
            button1.Text = "Tıkla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(69, 23);
            label1.TabIndex = 1;
            label1.Text = "Adınız:";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(6, 74);
            button2.Name = "button2";
            button2.Size = new Size(121, 34);
            button2.TabIndex = 2;
            button2.Text = "Yazdır";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(87, 37);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 14.25F);
            label3.Location = new Point(593, 53);
            label3.Name = "label3";
            label3.Size = new Size(71, 23);
            label3.TabIndex = 4;
            label3.Text = "Adınız:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 14.25F);
            label4.Location = new Point(566, 86);
            label4.Name = "label4";
            label4.Size = new Size(98, 23);
            label4.TabIndex = 5;
            label4.Text = "Soyadınız:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 14.25F);
            label5.Location = new Point(558, 123);
            label5.Name = "label5";
            label5.Size = new Size(106, 23);
            label5.TabIndex = 6;
            label5.Text = "Mesleğiniz:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 14.25F);
            label6.Location = new Point(698, 53);
            label6.Name = "label6";
            label6.Size = new Size(61, 23);
            label6.TabIndex = 7;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 14.25F);
            label7.Location = new Point(698, 86);
            label7.Name = "label7";
            label7.Size = new Size(60, 23);
            label7.TabIndex = 8;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Georgia", 14.25F);
            label8.Location = new Point(698, 123);
            label8.Name = "label8";
            label8.Size = new Size(61, 23);
            label8.TabIndex = 9;
            label8.Text = "label8";
            // 
            // button3
            // 
            button3.Location = new Point(558, 162);
            button3.Name = "button3";
            button3.Size = new Size(201, 57);
            button3.TabIndex = 10;
            button3.Text = "Bilgi getir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 266);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(257, 23);
            textBox1.TabIndex = 11;
            // 
            // button4
            // 
            button4.Location = new Point(6, 295);
            button4.Name = "button4";
            button4.Size = new Size(257, 37);
            button4.TabIndex = 12;
            button4.Text = "Aktar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Georgia", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label9.Location = new Point(327, 309);
            label9.Name = "label9";
            label9.Size = new Size(69, 25);
            label9.TabIndex = 13;
            label9.Text = "label9";
            label9.Click += label9_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(label9);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "x";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button3;
        private TextBox textBox1;
        private Button button4;
        private Label label9;
    }
}
