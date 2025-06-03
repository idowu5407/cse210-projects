public class Address
{
    // Properties
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // Constructor
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // Getters
    public bool IsInUSA()
    {
        return _country.Trim().ToUpper() == "USA";
    }

    // Method to return the full address as a formatted string
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
    
}