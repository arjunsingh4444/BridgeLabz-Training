using System;

class InvoiceGenerator
{
    static void Main()
    {
        Console.WriteLine("Enter invoice details:"); //  user to enter invoice details
        Console.WriteLine("Example: Logo Design - 3000 INR, Web Page - 4500 INR"); // example of invoice details

        string input = Console.ReadLine();

        string[] tasks = ParseInvoice(input); // split invoice string
        int total = GetTotalAmount(tasks); // calculate total amount

        Console.WriteLine("\nInvoice Details:");
        foreach (string task in tasks) // print each task and amount
        {
            Console.WriteLine(task); // print task
        }

        Console.WriteLine("\nTotal Amount: " + total + " INR"); // print total amount
    }

    // Method to split invoice string
    static string[] ParseInvoice(string input) // string input
    {
        // Split by comma
        return input.Split(','); 
    }

    // Method to calculate total amount
    static int GetTotalAmount(string[] tasks)
    {
        int total = 0;

        foreach (string task in tasks) // iterate through each task
        {
            // Split by hyphen
            string[] parts = task.Split('-');

            // Extract amount part
            string amountPart = parts[1].Replace("INR", "").Trim();

            int amount = Convert.ToInt32(amountPart); // convert amount to integer
            total += amount; // add to total
        }

        return total; // return total amount
    }
}
