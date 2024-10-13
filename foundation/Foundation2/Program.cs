using System;

class Program
{
    static void Main(string[] args)
    {
       // Create addresses
        Address address1 = new Address("123 Main St", "Mukono", "ID", "Uganda");
        Address address2 = new Address("456 Elm St", "Kyabakuza", "ON", "Uganda");

        // Create customers
        Customer customer1 = new Customer("Sphamandla Dube", address1);
        Customer customer2 = new Customer("Ruth Nakabire", address2);

        // Create products
        Product product1 = new Product("Product 1", "P001", 10.99, 2);
        Product product2 = new Product("Product 2", "P002", 5.99, 3);
        Product product3 = new Product("Product 3", "P003", 7.99, 1);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Display order information
        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}");
        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
        Console.WriteLine();
    }
}

