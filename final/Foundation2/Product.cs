using System;

public class Product
{
    private string _name;
    private string _ID;
    private double _price;
    private int _quantity;

    // Constructor
    public Product(string name, string ID, double price, int quantity)
    {
        _name = name;
        _ID = ID;
        _price = price;
        _quantity = quantity;
    }

    // Series of getter methods
    public string GetName()
    {
        return _name;
    }

    public string GetID()
    {
        return _ID;
    }

    public double GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    // Method to compute price based on quantity
    public double ComputePrice()
    {
        return _price * _quantity;
    }
}