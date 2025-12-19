using System;

class PurchasePrice
{
    static void Main()
    {
        Console.Write("Enter unit price: ");
        double unitPrice = Convert.ToDouble(Console.ReadLine());  //unit price 

        Console.Write("Enter quantity: ");
        int quantity = Convert.ToInt32(Console.ReadLine());  //quantity 

        double totalPrice = unitPrice * quantity;  //total price 

        Console.WriteLine($"The total purchase price is INR {totalPrice} if the quantity {quantity} and unit price is INR {unitPrice}"); //output 
    }
}
