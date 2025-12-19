using System;

class FeeDiscountOfStudent
{
    static void Main()
    {
        double fee = 125000; //fee 
        double discountPercent = 10;   //discount percentage

        double discountAmount = (fee * discountPercent) / 100; //discount amount
        double finalFee = fee - discountAmount;       //final discounted fee

        Console.WriteLine($"The discount amount is INR {discountAmount} and final discounted fee is INR {finalFee}");
    }
}
