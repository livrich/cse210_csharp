using System;

public class Order
{
    private List<Product> products = new List<Product>();
    private Customer _customer;
    private double _orderTotal;


    // Constructor
    public Order()
    {
        _customer = MakeCustomer();
    }

    // Getter method
    public double GetOrderTotal()
    {
        return _orderTotal;
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
        products.Add(product);
    }

    // Method to calculate total price of order
    public void CalcOrderTotal()
    {
        // Add up price of products
        foreach (Product p in products)
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
    }

    // Method to display packing label
    public void PackingLabel()
    {
        Console.WriteLine("Packing Label:");
        foreach (Product p in products)
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