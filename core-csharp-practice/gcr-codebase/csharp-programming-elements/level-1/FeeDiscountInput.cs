using System;

class FeeDiscountInput
{
    static void Main()
    {
        Console.Write("Enter fee amount: ");
        double fee = Convert.ToDouble(Console.ReadLine());  //take fee 

        Console.Write("Enter discount percent: ");
        double discountPercent = Convert.ToDouble(Console.ReadLine());  //take discount percent

        double discount = (fee * discountPercent) / 100;  //dicount 
        double finalFee = fee - discount;       //final fee after discount

        Console.WriteLine($"The discount amount is INR {discount} and final discounted fee is INR {finalFee}");  //output 
    }
}
