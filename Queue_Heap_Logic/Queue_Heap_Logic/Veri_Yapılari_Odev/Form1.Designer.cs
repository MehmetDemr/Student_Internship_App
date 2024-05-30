namespace Veri_Yapılari_Odev
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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            checkBox1 = new CheckBox();
            label7 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            label8 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button2 = new Button();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            checkBox2 = new CheckBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 59);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 0;
            label1.Text = "Student Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 109);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Student No:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 160);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 3;
            label4.Text = "Name-Surname:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 197);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 4;
            label3.Text = "GPA:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 235);
            label5.Name = "label5";
            label5.Size = new Size(121, 15);
            label5.TabIndex = 5;
            label5.Text = "Number of Absences:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 273);
            label6.Name = "label6";
            label6.Size = new Size(100, 15);
            label6.TabIndex = 6;
            label6.Text = "Student Societies:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(143, 270);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(146, 19);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Takes part in the group";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(525, 41);
            label7.Name = "label7";
            label7.Size = new Size(104, 15);
            label7.TabIndex = 8;
            label7.Text = "Students in Queue";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(380, 59);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(372, 244);
            listBox1.TabIndex = 9;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(143, 295);
            button1.Name = "button1";
            button1.Size = new Size(77, 39);
            button1.TabIndex = 10;
            button1.Text = "Add \r\nQueue";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(819, 59);
            label8.Name = "label8";
            label8.Size = new Size(301, 15);
            label8.TabIndex = 11;
            label8.Text = "Information about Students Withdrawn from the Queue";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(134, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(134, 154);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(134, 194);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(134, 229);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 15;
            // 
            // button2
            // 
            button2.Location = new Point(675, 309);
            button2.Name = "button2";
            button2.Size = new Size(77, 55);
            button2.TabIndex = 26;
            button2.Text = "Remove\r\nFrom \r\nQueue";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(965, 232);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 37;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(965, 197);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 36;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(965, 157);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 35;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(965, 109);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 34;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(974, 273);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(146, 19);
            checkBox2.TabIndex = 32;
            checkBox2.Text = "Takes part in the group";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(859, 273);
            label9.Name = "label9";
            label9.Size = new Size(100, 15);
            label9.TabIndex = 31;
            label9.Text = "Student Societies:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(838, 240);
            label10.Name = "label10";
            label10.Size = new Size(121, 15);
            label10.TabIndex = 30;
            label10.Text = "Number of Absences:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(927, 205);
            label11.Name = "label11";
            label11.Size = new Size(32, 15);
            label11.TabIndex = 29;
            label11.Text = "GPA:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(865, 165);
            label12.Name = "label12";
            label12.Size = new Size(94, 15);
            label12.TabIndex = 28;
            label12.Text = "Name-Surname:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(889, 117);
            label13.Name = "label13";
            label13.Size = new Size(70, 15);
            label13.TabIndex = 27;
            label13.Text = "Student No:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 526);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(textBox7);
            Controls.Add(textBox8);
            Controls.Add(checkBox2);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(button2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label7);
            Controls.Add(checkBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private CheckBox checkBox1;
        private Label label7;
        private ListBox listBox1;
        private Button button1;
        private Label label8;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button2;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private CheckBox checkBox2;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
    }
}