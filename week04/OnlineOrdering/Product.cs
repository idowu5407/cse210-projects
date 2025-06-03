public class Product
{
    // Properties
    private string _name;
    private string _productId;
    private decimal _price;
    private int _quantity;

    // Getters
    public Product(string name, string productId, decimal price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Methods
    public decimal GetTotalCost()
    {
        return _price * _quantity;
    }

    // Returns a packing label for the product
    public string GetPackingLabel()
    {
        return $"Product: {_name}, ID: {_productId}";
    }

}