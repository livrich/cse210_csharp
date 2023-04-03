using System;

public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    // Constructor
    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    // Series of getter methods
    public string GetStreet()
    {
        return _street;
    }

    public string GetCity()
    {
        return _city;
    }

    public string GetStateProvince()
    {
        return _stateProvince;
    }

    public string GetCountry()
    {
        return _country;
    }

    // Method to return address as one string
    public string SingleString()
    {
        return ($"{_street}\n{_city}, {_stateProvince}\n{_country}");
    }
}