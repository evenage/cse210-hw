using System;

class Program
{
    static void Main(string[] args)
    {
        // Create Address
        var address1 = new Address("357 Long Street", "Springfield", "IL", "US");

        // Create Customer
        var customer1 = new Customer("Beverly Hills", address1);
        var customers = new List<Customer> { customer1 };

        // Create Products
        var product1 = new Product("SoundBar", "f001", 1200.0f, 1);
        var product2 = new Product("Laptop", "f002", 25.5f, 2);

        // Create Order
        var order1 = new Order(customers);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        // Display Results
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"\nTotal Price: ${order1.CalculateTotalPrice()}");

        // 2nd order :
        // Create Address
        var address2 = new Address("2627", "WemeerPan", "Gauteng", "South Africa");

        // Create Customer
        var customer2 = new Customer("Abrahams", address2);
        var customers2 = new List<Customer> { customer2 };

        // Create Products
        var product3 = new Product("Machine Wash", "f003", 600.0f, 1);
        var product4 = new Product("Laptop", "f002", 25.6f, 2);

        // Create Order
        var order2 = new Order(customers2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Display Results
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"\nTotal Price: ${order2.CalculateTotalPrice()}");

    }
}