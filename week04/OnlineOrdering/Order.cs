using System.Collections.Generic;
using System.Text;

// using OnlineOrdering.Models;
public class Order
{
    private List<Product> _products;
    private Customer _customer;

    // Constructor that initializes the order with a customer
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    // Adds a product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Returns the total cost of the order, including shipping
    public decimal GetTotalCost()
    {
        decimal total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        total += _customer.LivesInUSA() ? 5 : 35;
        return total;
    }

    // Returns a packing label for the order
    public string GetPackingLabel()
    {
        StringBuilder sb = new StringBuilder();
        foreach (Product product in _products)
        {
            sb.AppendLine(product.GetPackingLabel());
        }
        return sb.ToString();
    }

    // Returns a shipping label for the order
    public string GetShippingLabel()
    {
        return _customer.GetShippingLabel();
    }
}