namespace WindowsFormApp
{
    partial class Form2
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
            comboBox1 = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "İstanbul", "İzmir", "Manisa", "Kırklareli", "Kırşehir", "Yozgat", "Muğla", "Antalya", "Burdur" });
            comboBox1.Location = new Point(132, 130);
            comboBox1.Margin = new Padding(5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(222, 33);
            comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(132, 187);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(225, 65);
            button1.TabIndex = 1;
            button1.Text = "Şehir ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(839, 133);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(55, 25);
            label1.TabIndex = 2;
            label1.Text = "Şehir";
            // 
            // button2
            // 
            button2.Location = new Point(941, 173);
            button2.Margin = new Padding(5);
            button2.Name = "button2";
            button2.Size = new Size(225, 53);
            button2.TabIndex = 3;
            button2.Text = "Ekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(912, 130);
            textBox1.Margin = new Padding(5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(315, 33);
            textBox1.TabIndex = 4;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Items.AddRange(new object[] { "Öğretmen", "Doktor", "Hemşire", "Mühendis" });
            listBox1.Location = new Point(132, 324);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(225, 179);
            listBox1.TabIndex = 5;
            // 
            // button3
            // 
            button3.Location = new Point(132, 509);
            button3.Name = "button3";
            button3.Size = new Size(136, 52);
            button3.TabIndex = 6;
            button3.Text = "Meslek Ekle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1004, 504);
            button4.Name = "button4";
            button4.Size = new Size(162, 57);
            button4.TabIndex = 7;
            button4.Text = "Kaydet";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(854, 434);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 8;
            label2.Text = "Meslek";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(964, 431);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(216, 33);
            textBox2.TabIndex = 9;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1257, 750);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(5);
            Name = "Form2";
            Text = "Arac Kullanımları 2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private Label label1;
        private Button button2;
        private TextBox textBox1;
        private ListBox listBox1;
        private Button button3;
        private Button button4;
        private Label label2;
        private TextBox textBox2;
    }
}