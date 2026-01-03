using System;
using System.Collections.Generic;

class Product
{
    public string Name; // public property
}

class Order // class with a public property of type List<Product>
{
    public List<Product> Products = new List<Product>(); // public property of type List<Product>
}

class Customer // class with a public property and a public method
{
    public string Name; 

    public void PlaceOrder(Order o) // public method that takes an Order as a parameter
    {
        Console.WriteLine(Name + " placed an order");
    }
}

class Program
{
    static void Main()
    {
        Product p1 = new Product { Name = "Laptop" };
        Order o1 = new Order();
        o1.Products.Add(p1);

        Customer c1 = new Customer { Name = "Arjun" };
        c1.PlaceOrder(o1);
    }
}
