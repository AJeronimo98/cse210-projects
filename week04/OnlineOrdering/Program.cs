using System;

namespace OnlineOrdering
{
    class Program
    {
        static void Main(string[] args)
        {
            // Order 1: Local (USA)
            Address address1 = new Address("789 North Walnut", "Rexburg", "ID", "USA");
            Customer customer1 = new Customer("Axel Jeronimo", address1);
            Order order1 = new Order(customer1);
            order1.AddProduct(new Product("Mechanical Keyboard", "K-900", 120.50, 1));
            order1.AddProduct(new Product("Gaming Mouse", "M-20", 45.00, 1));

            // Order 2: International
            Address address2 = new Address("Avenida Reforma 200", "Guatemala City", "GT", "Guatemala");
            Customer customer2 = new Customer("Angel Gabriel", address2);
            Order order2 = new Order(customer2);
            order2.AddProduct(new Product("Monitor 24 inch", "MON-24", 210.00, 2));
            order2.AddProduct(new Product("HDMI Cable", "C-HDMI", 15.75, 3));
            order2.AddProduct(new Product("Webcam HD", "WEB-88", 55.00, 1));

            // Display Results
            DisplayOrderDetails(order1, 1);
            DisplayOrderDetails(order2, 2);
        }

        static void DisplayOrderDetails(Order order, int orderNumber)
        {
            Console.WriteLine($"================ ORDER {orderNumber} ================");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"\nTOTAL PRICE: ${order.CalculateTotalPrice():0.00}");
            Console.WriteLine("==========================================\n");
        }
    }
}