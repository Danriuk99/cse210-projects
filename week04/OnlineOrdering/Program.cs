using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "L100", 899.99, 1));
        order1.AddProduct(new Product("Mouse", "M200", 25.50, 2));

        Address address2 = new Address("456 Queen St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Doe", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Keyboard", "K300", 45.00, 1));
        order2.AddProduct(new Product("Monitor", "MO400", 199.99, 1));
        order2.AddProduct(new Product("HDMI Cable", "H500", 12.75, 3));

        Order[] orders = { order1, order2 };

        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.GetTotalCost():F2}");
            Console.WriteLine(new string('=', 40));
        }
    }
}