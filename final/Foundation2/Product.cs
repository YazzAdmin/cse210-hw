using System;
public class Product
{
    private string _name;
    private string _productId;
    private decimal _price;
    private int _quantity;

    public Product(string name, string productId, decimal price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public decimal GetTotalPrice()
    {
        return _price * _quantity;
    }

    // Getter methods for product details
    public string GetName() => _name;
    public string GetProductId() => _productId;
}