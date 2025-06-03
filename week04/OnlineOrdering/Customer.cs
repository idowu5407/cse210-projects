public class Customer
{
    // Properties
    private string _name;
    private Address _address;

    // Constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    // Getters
    public string GetName()
    {
        return _name;
    }

    // Method to return a formatted customer information string
    public string GetShippingLabel()
    {
        return $"{_name}\n{_address.GetFullAddress()}";
    }
    
}