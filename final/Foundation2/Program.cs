using System;
class Program
{
    static void Main(string[] args)
    {   //Order1
        // forCreating Address and Customer
        Address customerAddress1 = new Address("1313 S Disneyland Dr", "Anaheim", "California", "USA");
        Customer customer1 = new Customer("Jeon Jung-Kook", customerAddress1);

        // forCreating Products
        Product product1 = new Product("Product 1", "4920-30299V", 10.50m, 2);
        Product product2 = new Product("Product 2", "678-864H", 20.75m, 3);

        // forCreating Order
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        //Order2
        Address customerAddress2 = new Address("1423 BLVD. Cuautemoc Sur, Davial", "Tijuana", "Baja California", "Mexico");
        Customer customer2 = new Customer("Taehyung Kim", customerAddress2);

        // forCreating Products
        Product product3 = new Product("Product 3", "89008-9K", 10.50m, 2);
        Product product4 = new Product("Product 4", "465-900L", 20.75m, 3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        // forDisplaying Order Details
        Console.WriteLine("order1:");
        Console.WriteLine("\n");
        Console.WriteLine("Packing Label:");
        Console.WriteLine("\n");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine("\nTotal Price: $" + order1.CalculateTotalPrice());

        // forDisplaying Order Details
        
        Console.WriteLine("\norder2:");
        Console.WriteLine("\n");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine("\nTotal Price: $" + order2.CalculateTotalPrice());

    }

}
