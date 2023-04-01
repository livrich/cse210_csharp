using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");

        // List of orders
        List<Order> orders = new List<Order>();

        // Instance of Product class
        Product p = new Product("Rubber Duck", "123", 1.50, 20);
        // Test to see if class is working
        Console.WriteLine(p.GetName());
        Console.WriteLine(p.ComputePrice());
    }
}