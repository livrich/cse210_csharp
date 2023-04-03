using System;

public class Order
{
    private List<Product> _products;
    private Customer _customer;
    private double _orderTotal;


    // Constructor
    public Order()
    {
        _products = new List<Product>();
        _customer = MakeCustomer();
        _orderTotal = 0;
    }

    // Getter methods
    public double GetOrderTotal()
    {
        return _orderTotal;
    }

    public Customer GetCustomer()
    {
        return _customer;
    }

    // Method to create a customer
    public Customer MakeCustomer()
    {
        // Get name of customer from user
        Console.Write("Name of customer: ");
        string name = Console.ReadLine();

        // Call customer class
        Customer c = new Customer(name);
        return c;
    }

    // Method to create a product
    public Product MakeProduct()
    {
        // Get product information from user
        Console.Write("Name of product: ");
        string name = Console.ReadLine();
        Console.Write("ID of product: ");
        string ID = Console.ReadLine();
        Console.Write("Price of product: ");
        double price = Double.Parse(Console.ReadLine());
        Console.Write("Quantity of product: ");
        int quantity = Int32.Parse(Console.ReadLine());

        // Create instance of product class
        Product p = new Product(name, ID, price, quantity);
        return p;
    }

    // Method to add product to order
    public void AddProductToOrder()
    {
        Product product = MakeProduct();
        _products.Add(product);
    }

    // Method to calculate total price of order
    public double CalcOrderTotal()
    {
        // Add up price of products
        foreach (Product p in _products)
        {
            _orderTotal += p.ComputePrice();
        }

        // Add price of shipping
        int shippingCost = 0;
        if (_customer.GetInUSA() == true)
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        _orderTotal += shippingCost;

        return _orderTotal;
    }

    // Method to display packing label
    public void PackingLabel()
    {
        Console.WriteLine("Packing Label:");
        foreach (Product p in _products)
        {
            Console.WriteLine($"{p.GetName()} - {p.GetID()}");
        }
    }

    // Method to display shipping label
    public void ShippingLabel()
    {
        Console.WriteLine("Shipping Label:");
        Console.WriteLine($"{_customer.GetName()}");
        Console.WriteLine($"{_customer.GetAddress().SingleString()}");
    }
}