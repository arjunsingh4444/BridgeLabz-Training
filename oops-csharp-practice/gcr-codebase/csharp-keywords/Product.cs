using System;

class Product
{
    static int Discount = 10; // percentage

    readonly int ProductID; // read-only
    string ProductName; // mutable
    int Price;
    int Quantity;

    public Product(int id, string name, int price, int qty) // constructor
    {
        this.ProductID = id;
        this.ProductName = name;
        this.Price = price;
        this.Quantity = qty;
    } 

    static void UpdateDiscount(int newDiscount) // static method to update discount
    {
        Discount = newDiscount; // update the static variable Discount
    }

    public void Display(object obj) 
    {
        if (obj is Product) // check if the object is of type Product
        {
            Console.WriteLine(ProductName + " - ₹" + Price); // display the product details 
            Console.WriteLine("Discount: " + Discount + "%"); // display the discount
        }
    }

    static void Main()
    {
        Product p1 = new Product(101, "Laptop", 50000, 1); // create a product object
        UpdateDiscount(15); // update the discount
        p1.Display(p1); // display the product details with discount
    }
}