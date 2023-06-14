using System.Windows.Forms;

namespace Assignment1_Exercise5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private decimal CalcStayCharges(int days)
        {
            return 350 * days;
        }

        private decimal CalcMiscCharges(decimal medication, decimal surgery, decimal labFees, decimal rehabCharges)
        {
            return medication + surgery + labFees + rehabCharges;
        }

        private decimal CalcTotalCharges(int days, decimal medication, decimal surgery, decimal labFees, decimal rehabCharges)
        {
            decimal stayCharges = CalcStayCharges(days);
            decimal miscCharges = CalcMiscCharges(medication, surgery, labFees, rehabCharges);
            return stayCharges + miscCharges;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                int days = Convert.ToInt32(textBox1.Text);
                decimal medication = Convert.ToDecimal(textBox2.Text);
                decimal surgery = Convert.ToDecimal(textBox3.Text);
                decimal labFees = Convert.ToDecimal(textBox4.Text);
                decimal rehabCharges = Convert.ToDecimal(textBox5.Text);

                decimal stayCharges = CalcStayCharges(days);
                decimal miscCharges = CalcMiscCharges(medication, surgery, labFees, rehabCharges);
                decimal totalCharges = CalcTotalCharges(days, medication, surgery, labFees, rehabCharges);

                Bill.Items.Clear();
                Bill.Items.Add("Hospital Stay: " + stayCharges.ToString("C"));
                Bill.Items.Add("Medication Charges: " + medication.ToString("C"));
                Bill.Items.Add("Surgical Charges: " + surgery.ToString("C"));
                Bill.Items.Add("Lab fees: " + labFees.ToString("C"));
                Bill.Items.Add("Physical rehabilitation charges: " + rehabCharges.ToString("C"));
                Bill.Items.Add("--------------------------------------------");
                Bill.Items.Add("Total Charges: " + totalCharges.ToString("C"));
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }


        private void Bill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}