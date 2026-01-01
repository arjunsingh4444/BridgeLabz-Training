// This menu-driven C# program simulates a cafeteria ordering system using arrays and methods.

// Stores food items and their prices in parallel arrays

// Uses an orderCount array to track how many times each item is ordered

// Provides 3 options:

// Show Menu – displays items with prices

// Order Items – user selects items by index; repeated selections increase quantity

// Exit & Show Bill – displays ordered items with quantity and total amount

// Uses loops and methods for clean and organized code

// Prevents duplicate item entries by counting quantity instead

using System;

class CafeteriaMenuApp
{
    static void Main()
    {
        // Food items available in cafeteria
        string[] items =
        {
            "Idli", "Dosa", "Vada", "Poha", "Sandwich",
            "Burger", "Pizza", "Pasta", "Tea", "Coffee"
        };

        // Prices of food items (same index as items array)
        int[] prices = { 30, 40, 25, 35, 50, 80, 120, 100, 15, 20 };

        // Stores how many times each item is ordered
        int[] orderCount = new int[items.Length];

        while (true)
        {
            // Main menu
            Console.WriteLine("\n---- Cafeteria Menu App ----");
            Console.WriteLine("1. Show Menu");
            Console.WriteLine("2. Order Items");
            Console.WriteLine("3. Exit & Show Bill");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                ShowMenu(items, prices);
            }
            else if (choice == 2)
            {
                TakeOrder(items, orderCount);
            }
            else if (choice == 3)
            {
                ShowBill(items, prices, orderCount);
                break; // exit program
            }
            else
            {
                Console.WriteLine("Please enter a valid option!");
            }
        }
    }

    // Shows all food items with prices
    static void ShowMenu(string[] items, int[] prices)
    {
        Console.WriteLine("\n---- Food Menu ----");
        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine(i + " - " + items[i] + " (₹" + prices[i] + ")");
        }
    }

    // Allows user to order items
    static void TakeOrder(string[] items, int[] orderCount)
    {
        Console.Write("\nEnter item number to order (-1 to stop): ");
        int index = int.Parse(Console.ReadLine());

        while (index != -1)
        {
            orderCount[index]++; // increase count
            Console.WriteLine(items[index] + " added.");

            Console.Write("Enter item number to order (-1 to stop): ");
            index = int.Parse(Console.ReadLine());
        }
    }

    // Displays final ordered items and total bill
    static void ShowBill(string[] items, int[] prices, int[] orderCount)
    {
        Console.WriteLine("\n---- Final Bill ----");
        int totalAmount = 0;
        bool ordered = false;

        for (int i = 0; i < items.Length; i++)
        {
            if (orderCount[i] > 0)
            {
                int itemTotal = orderCount[i] * prices[i];
                Console.WriteLine(items[i] + " x " + orderCount[i] + " = ₹" + itemTotal);
                totalAmount += itemTotal;
                ordered = true;
            }
        }

        if (!ordered)
        {
            Console.WriteLine("No items ordered.");
        }
        else
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Total Amount: ₹" + totalAmount);
        }
    }
}
