using System;

namespace Assignment1_Exercise4
{
    public partial class Form1 : Form
    {
        double service = 0;
        double parts = 0;
        double tax = 0;
        double total = 0;

        private Dictionary<string, double> routineServices = new Dictionary<string, double>()
        {
            { "Oil Change", 26.00 },
            { "Lube Job", 18.00 },
            { "Radiator Flush", 30.00 },
            { "Transmission Flush", 80.00 },
            { "Inspection", 15.00 },
            { "Muffler Replacement", 100.00 },
            { "Tire Rotation", 20.00 }
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                service += this.routineServices["Tire Rotation"];
            }
            else
            {
                service -= this.routineServices["Tire Rotation"];
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                service += this.routineServices["Oil Change"];
            }
            else
            {
                service -= this.routineServices["Oil Change"];
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                service += this.routineServices["Lube Job"];
            }
            else
            {
                service -= this.routineServices["Lube Job"];
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                service += this.routineServices["Radiator Flush"];
            }
            else
            {
                service -= this.routineServices["Radiator Flush"];
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                service += this.routineServices["Transmission Flush"];
            }
            else
            {
                service -= this.routineServices["Transmission Flush"];
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                service += this.routineServices["Inspection"];
            }
            else
            {
                service -= this.routineServices["Inspection"];
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                service += this.routineServices["Muffler Replacement"];
            }
            else
            {
                service -= this.routineServices["Muffler Replacement"];
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double laborInput = 0;
            if (textBox2.Text != "")
            {
                laborInput = Convert.ToDouble(textBox2.Text);
            }
            textBox3.Text = (service + laborInput).ToString();

            double partsInput = 0;
            if (textBox1.Text != "")
            {
                partsInput = Convert.ToDouble(textBox1.Text);
            }
            textBox4.Text = (partsInput).ToString();

            double taxInput = partsInput * 0.12;
            textBox5.Text = taxInput.ToString();

            double total = laborInput + partsInput + service;

            textBox6.Text = total.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}