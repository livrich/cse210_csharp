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

        // Instance of Address class
        Address a = new Address("743 E Whisper Bend Dr", "Draper", "UT", "USA");
        // Test to see if class is working
        Console.WriteLine(a.GetStateProvince());
        Console.WriteLine(a.IsInUSA());
        Console.WriteLine(a.SingleString());

        // Instance of Customer class
        Customer c = new Customer("Jake");
        // Test to see if class is working
        Console.WriteLine(c.GetAddress());
        Address address = c.GetAddress();
        Console.WriteLine(address.SingleString());
    }
}