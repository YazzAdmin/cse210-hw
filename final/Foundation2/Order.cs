using System;
public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal CalculateTotalPrice()
    {
        decimal totalPrice = 0;
        foreach (var product in _products)
        {
            totalPrice += product.GetTotalPrice();
        }

        decimal shippingCost = _customer.LivingInUSA() ? 5 : 35;
        return totalPrice + shippingCost;
    }

    public string GetPackingLabel()
    {
        string Label = "";
        foreach (var product in _products)
        {
            Label += $"{product.GetName()} \n ID: {product.GetProductId()}\n";
        }
        return Label;
    }

    public string GetShippingLabel()
    {
        return _customer.GetCustomerInfo();
    }
}