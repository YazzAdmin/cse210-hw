using System;

namespace Program2Encapsulation;

class Program
{
    static void Main(string[] args)
    {
        List<Order> lstOrders = new List<Order>();

        Order order1 = new Order
        {
            Customer = new Customer
            {
                Name = "Customer Name 1",
                Address = new Address 
                { 
                    City = "Los Angeles",
                    Country ="USA",
                    StateProvince = "California",
                    StreetAddress = "Hooper Ave. 3415"
                }
            },
            LstProducts = new List<Product> 
            { 
                new Product 
                {                                 
                    Name = "Product 1",
                    Price = 12.89,
                    ProductId = 12,
                    Quantity = 2
                },
                new Product 
                {
                    Name = "Product 2",
                    Price = 25.14,
                    ProductId = 22,
                    Quantity = 4
                }
            }
        };

        Order order2 = new Order
        {
            Customer = new Customer
            {
                Name = "Customer Name 2",
                Address = new Address
                {
                    City = "Tijuana",
                    Country = "MEXICO",
                    StateProvince = "Baja California",
                    StreetAddress = "Blvd Las Americas 22024"
                }
            },
            LstProducts = new List<Product>
            {
                new Product
                {
                    Name = "Product 1",
                    Price = 54.2,
                    ProductId = 10,
                    Quantity = 1
                },
                new Product
                {
                    Name = "Product 2",
                    Price = 35.28,
                    ProductId = 7,
                    Quantity = 3
                },
                new Product
                {
                    Name = "Product 3",
                    Price = 19.30,
                    ProductId = 37,
                    Quantity = 5
                }
            }
        };


        lstOrders.Add(order1);
        lstOrders.Add(order2);

        foreach (var order in lstOrders)
        {
            Console.WriteLine(order.getPackingLabel());
            Console.WriteLine(order.getShippingLabel());
            Console.WriteLine("$ " + order.getTotalPriceOfOrder().ToString());
            Console.WriteLine("\n");
        }

        Console.ReadLine();
    }
}

public class Order
{
    private List<Product> lstProducts;
    private Customer customer;

    public List<Product> LstProducts
    {
        get { return lstProducts; }
        set { lstProducts = value; }
    }

    public Customer Customer
    {
        get { return customer; }
        set { customer = value; }
    }

    public double getTotalPriceOfOrder()
    {
        double totalCostOfOrder = 0;

        foreach (var item in lstProducts)
        {
            totalCostOfOrder += (item.Price * item.Quantity);
        }

        if (customer.isLivingInUsa() == true)
        {
            totalCostOfOrder += 5;
        }
        else
        {
            totalCostOfOrder += 35;
        }

        return totalCostOfOrder;
    }

    public string getPackingLabel()
    {
        string strPackingLabel = string.Empty;

        foreach (var item in lstProducts)
        {
            strPackingLabel += "Product Name: " + item.Name + " Product Id: " + item.ProductId + "\n";
        }

        return strPackingLabel;
    }

    public string getShippingLabel()
    {
        string strShippingLabel = string.Empty;

        strShippingLabel = "Customer Name: " + customer.Name + "\n" + "Customer Address: " + customer.Address.getAllFields();

        return strShippingLabel;
    }


}

public class Product
{
    private string name = string.Empty;
    private int productId;
    private double price;
    private int quantity;

    public String Name
    {
        get { return name; }
        set { name = value; }
    }

    public int ProductId
    {
        get { return productId; }
        set { productId = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    public int Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }
}

public class Customer
{
    private string name = string.Empty;
    private Address address = new Address();

    public String Name
    {
        get { return name; }
        set { name = value; }
    }

    public Address Address
    {
        get { return address; }
        set { address = value; }
    }

    public bool isLivingInUsa()
    {
        if (address.isLivingInUsa() == true)
        {
            return true;
        }
        else
        { 
            return false; 
        }
    }
}

public class Address
{
    private string streetAddress = string.Empty;
    private string city = string.Empty;
    private string stateProvince = string.Empty;
    private string country = string.Empty;

    public String StreetAddress
    {
        get { return streetAddress;  }
        set { streetAddress = value; }
    }

    public String City
    {
        get { return city; }
        set { city = value; }
    }

    public String StateProvince
    {
        get { return stateProvince; }
        set { stateProvince = value; }
    }

    public String Country
    {
        get { return country; }
        set { country = value; }
    }

    public bool isLivingInUsa()
    {
        if (country.Trim().ToLower() == "usa") 
        { 
            return true;
        }
        else
        {
            return false;
        }
    }

    public string getAllFields()
    {
        return streetAddress + "\n" + city + "\n" + stateProvince + "\n" + country;
    }
}