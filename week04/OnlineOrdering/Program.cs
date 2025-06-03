using System;

class Program
{
    static void Main(string[] args)
    {
        // Address and customer 1 (USA)
        Address address1 = new Address("123 Main St", "Salt Lake City", "UT", "USA");
        Customer customer1 = new Customer("Alice Johnson", address1);

        // Products for order 1
        Product p1 = new Product("Notebook", "N001", 3.50m, 5);
        Product p2 = new Product("Pen", "P010", 1.20m, 10);

        // Order 1
        Order order1 = new Order(customer1);
        order1.AddProduct(p1);
        order1.AddProduct(p2);

        // Displaying packing and shipping labels for order 1
        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Order 1 Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Order 1 Total Cost: ${order1.GetTotalCost():F2}\n");

        // Address and customer 2 (Non-USA)
        Address address2 = new Address("45 King St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Bob Smith", address2);

        // Products for order 2
        Product p3 = new Product("Backpack", "B022", 45.00m, 1);
        Product p4 = new Product("Water Bottle", "W007", 12.99m, 2);

        // Order 2
        Order order2 = new Order(customer2);
        order2.AddProduct(p3);
        order2.AddProduct(p4);

        // Displaying packing and shipping labels for order 2
        Console.WriteLine("Order 2 Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Order 2 Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Order 2 Total Cost: ${order2.GetTotalCost():F2}");
    }
}