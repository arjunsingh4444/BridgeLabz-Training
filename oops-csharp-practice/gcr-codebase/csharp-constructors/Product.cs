using System;

class Product
{
    // Instance variables (unique for each object)
    public string productName;
    public double price;

    // Class variable (shared by all objects)
    public static int totalProducts = 0;

    // Constructor
    public Product(string name, double price)
    {
        this.productName = name;
        this.price = price;
        totalProducts++; // increase count when object is created
    }

    // Instance method
    public void DisplayProductDetails()
    {
        Console.WriteLine("Product Name: " + productName);
        Console.WriteLine("Price: " + price);
    }

    // Class method
    public static void DisplayTotalProducts()
    {
        Console.WriteLine("Total Products: " + totalProducts);
    }
}

class ProductDemo
{
    static void Main()
    {
        Product p1 = new Product("Laptop", 50000);
        Product p2 = new Product("Mobile", 20000);

        p1.DisplayProductDetails();
        p2.DisplayProductDetails();

        Product.DisplayTotalProducts();
    }
}
