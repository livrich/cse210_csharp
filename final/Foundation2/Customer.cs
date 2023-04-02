using System;

public class Customer
{
    private bool _inUSA;
    private string _name;
    private Address _address;

    // Constructor
    public Customer(string name)
    {
        _name = name;
        _address = CreateAddress();
        _inUSA = _address.IsInUSA();
    }

    // Series of getters
    public bool GetInUSA()
    {
        return _inUSA;
    }

    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }

    // Method to call address class
    private Address CreateAddress()
    {
        // Get information about address from user
        Console.WriteLine("Enter the following address inforamtion");
        Console.Write("Street: ");
        string street = Console.ReadLine();
        Console.Write("City: ");
        string city = Console.ReadLine();
        Console.Write("State/Province: ");
        string stateProvince = Console.ReadLine();
        Console.Write("Country: ");
        string country = Console.ReadLine();

        Address a = new Address(street, city, stateProvince, country);
        // Address a = new Address("123 Sweet Street", "Kumamoto", "Kyushu", "Japan");
        return a;
    }
}