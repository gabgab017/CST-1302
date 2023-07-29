using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab13
{
    public partial class Form1 : Form
    {
        private object procuctTableAdapter;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.productTableAdapter.Fill(this.productDBDataSet.Product);

        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productDBDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.productTableAdapter.FillByPrice(this.productDBDataSet.Product);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.productTableAdapter.FillByUnitsMoreThan100(this.productDBDataSet.Product);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal averagePrice;
            averagePrice = (decimal)this.productTableAdapter.AveragePrice();
            MessageBox.Show("Average price of all items: " + averagePrice.ToString("e"));
        }
    }
}
