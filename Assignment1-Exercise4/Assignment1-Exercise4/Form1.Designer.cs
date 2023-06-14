namespace Assignment1_Exercise4
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
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            groupBox5 = new GroupBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox6 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(10, 27);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(127, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Oil change ($26.00)";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(10, 52);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(116, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Lube job ($18.00)";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(6, 27);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(143, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Radiator flush ($30.00)";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(6, 52);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(167, 19);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Transmission flush ($80.00)";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(10, 29);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(125, 19);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "Inspection ($15.00)";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(10, 54);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(184, 19);
            checkBox6.TabIndex = 5;
            checkBox6.Text = "Muffler replacement ($100.00)";
            checkBox6.UseVisualStyleBackColor = true;
            checkBox6.CheckedChanged += checkBox6_CheckedChanged;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(10, 79);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(134, 19);
            checkBox7.TabIndex = 6;
            checkBox7.Text = "Tire rotation ($20.00)";
            checkBox7.UseVisualStyleBackColor = true;
            checkBox7.CheckedChanged += checkBox7_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(72, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(72, 66);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 8;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(243, 199);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Location = new Point(21, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 79);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Oil and Lube";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(checkBox4);
            groupBox2.Location = new Point(227, 32);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 79);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Flushes";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(checkBox6);
            groupBox3.Controls.Add(checkBox5);
            groupBox3.Controls.Add(checkBox7);
            groupBox3.Location = new Point(21, 130);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 108);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Misc";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(textBox1);
            groupBox4.Controls.Add(textBox2);
            groupBox4.Location = new Point(227, 130);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(200, 108);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Parts and Labor";
            groupBox4.Enter += groupBox4_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 69);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 14;
            label3.Text = "Labor ($)";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 34);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 13;
            label2.Text = "Parts ($)";
            label2.Click += label2_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textBox6);
            groupBox5.Controls.Add(textBox5);
            groupBox5.Controls.Add(textBox4);
            groupBox5.Controls.Add(textBox3);
            groupBox5.Controls.Add(label4);
            groupBox5.Controls.Add(label7);
            groupBox5.Controls.Add(label6);
            groupBox5.Controls.Add(label5);
            groupBox5.Location = new Point(21, 264);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(406, 176);
            groupBox5.TabIndex = 13;
            groupBox5.TabStop = false;
            groupBox5.Text = "Summary";
            groupBox5.Enter += groupBox5_Enter;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(170, 132);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(194, 23);
            textBox6.TabIndex = 14;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(170, 102);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(194, 23);
            textBox5.TabIndex = 14;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(170, 66);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(194, 23);
            textBox4.TabIndex = 19;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(170, 33);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(194, 23);
            textBox3.TabIndex = 14;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 135);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 18;
            label4.Text = "Total fees";
            label4.Click += label4_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 105);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 17;
            label7.Text = "Tax (on Parts)";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 69);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 16;
            label6.Text = "Parts";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 36);
            label5.Name = "label5";
            label5.Size = new Size(100, 15);
            label5.TabIndex = 15;
            label5.Text = "Service and Labor";
            label5.Click += label5_Click;
            // 
            // button1
            // 
            button1.Location = new Point(54, 479);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(185, 479);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 15;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(310, 479);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 16;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(groupBox1);
            groupBox6.Controls.Add(button3);
            groupBox6.Controls.Add(label1);
            groupBox6.Controls.Add(button2);
            groupBox6.Controls.Add(groupBox2);
            groupBox6.Controls.Add(button1);
            groupBox6.Controls.Add(groupBox3);
            groupBox6.Controls.Add(groupBox5);
            groupBox6.Controls.Add(groupBox4);
            groupBox6.Location = new Point(221, 44);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(453, 532);
            groupBox6.TabIndex = 17;
            groupBox6.TabStop = false;
            groupBox6.Text = "Joe's car service billing";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 620);
            Controls.Add(groupBox6);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox5;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Button button3;
        private GroupBox groupBox6;
    }
}