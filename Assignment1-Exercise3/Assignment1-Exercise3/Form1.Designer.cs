namespace Assignment1_Exercise3
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Result = new ListBox();
            groupBox1 = new GroupBox();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(51, 304);
            button1.Name = "button1";
            button1.Size = new Size(103, 32);
            button1.TabIndex = 0;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(38, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(278, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(38, 122);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(278, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 49);
            label1.Name = "label1";
            label1.Size = new Size(157, 15);
            label1.TabIndex = 4;
            label1.Text = "Number of calories from fat:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 104);
            label2.Name = "label2";
            label2.Size = new Size(218, 15);
            label2.TabIndex = 5;
            label2.Text = "Number of calories from carbohydrates:";
            label2.Click += label2_Click;
            // 
            // Result
            // 
            Result.FormattingEnabled = true;
            Result.ItemHeight = 15;
            Result.Location = new Point(38, 183);
            Result.Name = "Result";
            Result.Size = new Size(278, 94);
            Result.TabIndex = 6;
            Result.SelectedIndexChanged += Result_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(Result);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(23, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(354, 375);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Calories counting app";
            // 
            // button2
            // 
            button2.Location = new Point(200, 304);
            button2.Name = "button2";
            button2.Size = new Size(103, 32);
            button2.TabIndex = 8;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 426);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private ListBox Result;
        private GroupBox groupBox1;
        private Button button2;
    }
}