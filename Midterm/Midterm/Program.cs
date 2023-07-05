namespace Midterm
{
    internal static class Program
    {

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

        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
