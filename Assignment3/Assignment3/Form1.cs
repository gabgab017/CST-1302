namespace Assignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        class Employee
        {
            public string EmployeeName { get; set; }
            public int EmployeeNumber { get; set; }
        }

        class ProductionWorker : Employee
        {
            public int ShiftNumber { get; set; }
            public double HourlyPayRate { get; set; }

            public ProductionWorker(string name, int empNumber, int shiftNumber, double hourlyPayRate)
            {
                EmployeeName = name;
                EmployeeNumber = empNumber;
                ShiftNumber = shiftNumber;
                HourlyPayRate = hourlyPayRate;
            }
        }

        class ShiftSupervisor : Employee
        {
            public double AnnualSalary { get; set; }
            public double AnnualProductionBonus { get; set; }

            public ShiftSupervisor(string name, int empNumber, double annualSalary, double annualProductionBonus)
            {
                EmployeeName = name;
                EmployeeNumber = empNumber;
                AnnualSalary = annualSalary;
                AnnualProductionBonus = annualProductionBonus;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int empNumber = int.Parse(textBox2.Text);
            int shiftNumber = int.Parse(textBox3.Text);
            double hourlyPayRate = double.Parse(textBox4.Text);

            ProductionWorker productionWorker = new ProductionWorker(name, empNumber, shiftNumber, hourlyPayRate);

            string message = "Employee Information:\n" +
                             "----------------------\n" +
                             "Employee Name: " + productionWorker.EmployeeName + "\n" +
                             "Employee Number: " + productionWorker.EmployeeNumber + "\n" +
                             "Shift Number: " + productionWorker.ShiftNumber + "\n" +
                             "Hourly Pay Rate: " + productionWorker.HourlyPayRate + "\n";

            double annualSalary = double.Parse(textBox5.Text);
            double annualProductionBonus = double.Parse(textBox6.Text);

            ShiftSupervisor shiftSupervisor = new ShiftSupervisor(name, empNumber, annualSalary, annualProductionBonus);

            message += "\nShift Supervisor Information:\n" +
                       "----------------------\n" +
                       "Annual Salary: " + shiftSupervisor.AnnualSalary + "\n" +
                       "Annual Production Bonus: " + shiftSupervisor.AnnualProductionBonus + "\n";

            MessageBox.Show(message, "Employee and Shift Supervisor Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}