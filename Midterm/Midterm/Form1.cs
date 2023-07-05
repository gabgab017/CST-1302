using System.Windows.Forms;

namespace Midterm
{
    public partial class Form1 : Form
    {
        RetailItem[] items = new RetailItem[3];

        public Form1()
        {
            InitializeComponent();

            items[0] = new RetailItem("Jacket", 12, 59.99m);
            items[1] = new RetailItem("Jeans", 40, 34.95m);
            items[2] = new RetailItem("Shirt", 20, 24.95m);

            listBox1.DataSource = items;
            listBox1.DisplayMember = "Description";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RetailItem selectedItem = (RetailItem)listBox1.SelectedItem;
            listBox1.Items.Clear();
            listBox1.Items.Add($"Description: {selectedItem.Description}");
            listBox1.Items.Add($"Units on Hand: {selectedItem.UnitsOnHand}");
            listBox1.Items.Add($"Price: {selectedItem.Price}");
        }
    }

    public class RetailItem
    {
        public string Description { get; set; }
        public int UnitsOnHand { get; set; }
        public decimal Price { get; set; }

        public RetailItem(string description, int unitsOnHand, decimal price)
        {
            Description = description;
            UnitsOnHand = unitsOnHand;
            Price = price;
        }
    }
}
