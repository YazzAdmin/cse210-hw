using System;
class Program
{
    static void Main(string[] args)
    {
        // forCreating Address and Customer
        Address customerAddress = new Address("1313 S Disneyland Dr", "Anaheim", "California", "USA");
        Customer customer = new Customer("Jeon Jung-Kook", customerAddress);

        // forCreating Products
        Product product1 = new Product("Product 1", "4920-30299V", 10.50m, 2);
        Product product2 = new Product("Product 2", "678-864H", 20.75m, 3);

        // forCreating Order
        Order order = new Order(customer);
        order.AddProduct(product1);
        order.AddProduct(product2);

        // forDisplaying Order Details
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());

        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order.GetShippingLabel());

        Console.WriteLine("\nTotal Price: $" + order.CalculateTotalPrice());
    }
}