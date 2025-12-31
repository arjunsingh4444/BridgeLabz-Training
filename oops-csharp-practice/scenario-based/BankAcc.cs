using System;

class Bank
{
    public string AccountNumber; // Unique account number
    public string UserName;        // Name of user
    public double Balance; // Current balance
}

class BankSystem
{
    Bank[] accounts = new Bank[10]; // Array to store accounts
    int count = 0;

    // Manager creates account
    public void AddAccount() // Manager adds new account
    {
        if (count >= accounts.Length) // Check if account limit reached
        {
            Console.WriteLine("Account limit reached.");
            return;
        }

        Bank acc = new Bank(); // Create new account object 

        Console.Write("Enter Account Number: ");    // Get account details from user
        acc.AccountNumber = Console.ReadLine();

        Console.Write("Enter User Name: ");
        acc.UserName = Console.ReadLine();

        Console.Write("Enter Initial Balance: ");
        acc.Balance = Convert.ToDouble(Console.ReadLine());

        accounts[count] = acc; // Add account to array
        count++; // Increment count of accounts

        Console.WriteLine(" congrats! your Account created successfully.");
    }

    // Find account using account number
    public Bank GetAccount(string accNo) // Manager finds account using account number
    {
        for (int i = 0; i < count; i++) // Loop through all accounts
        {
            if (accounts[i].AccountNumber == accNo) // Check if account number matches
            {
                return accounts[i]; // Return account object if found
            }
        }
        return null;
    }
}

class User
{
    BankSystem bankSystem; // Reference to BankSystem object

    public User(BankSystem system) // Constructor to initialize reference to BankSystem object
    {
        bankSystem = system; // Set reference to BankSystem object
    }

    public void UserMenu() // User menu  
    {
        Console.Write("Enter your Account Number: "); // Get account number from user
        string accNo = Console.ReadLine();

        Bank acc = bankSystem.GetAccount(accNo); // Find account using account number

        if (acc == null)
        {
            Console.WriteLine("Account not found.");
            return;
        }

        int choice;
        do
        {
            Console.WriteLine("\\\\\\\\ USER MENU ///////");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice) // Switch case for user menu options 
            { 
                case 1:
                    Console.WriteLine("Balance: " + acc.Balance); // Check balance
                    break; 

                case 2:
                    Console.Write("Enter deposit amount: ");
                    double dep = Convert.ToDouble(Console.ReadLine()); // Get deposit amount
                    if (dep > 0)
                    {
                        acc.Balance += dep; // Add deposit amount to balance
                        Console.WriteLine("Deposit successful.");
                    }
                    else
                        Console.WriteLine("Invalid amount.");
                    break;

                case 3:
                    Console.Write("Enter withdrawal amount: ");
                    double wit = Convert.ToDouble(Console.ReadLine());
                    if (wit > acc.Balance) // Check if withdrawal amount is valid and sufficient balance is available
                        Console.WriteLine("Insufficient balance.");
                    else if (wit <= 0) // Check if withdrawal amount is valid
                        Console.WriteLine("Invalid amount.");
                    else
                    {
                        acc.Balance -= wit; // Subtract withdrawal amount from balance
                        Console.WriteLine("Withdrawal successful.");
                    }
                    break;

                case 4:
                    Console.WriteLine("User logged out.");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        } while (choice != 4); // Loop until user chooses to exit
    }
}

class Manager
{
    BankSystem bankSystem; // Reference to BankSystem object

    public Manager(BankSystem system) // Constructor to initialize reference to BankSystem object
    {
        bankSystem = system;
    }

    public void ManagerMenu() // Manager menu
    {
        int choice;
        do
        {
            Console.WriteLine("\n\\\\MANAGER MENU//////"); // Display manager menu
            Console.WriteLine("1. Add New Account");
            Console.WriteLine("2. View Account Details");
            Console.WriteLine("3. Exit");
            Console.Write("Enter choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice) // Switch case for manager menu options 
            {
                case 1:
                    bankSystem.AddAccount(); // Add new account
                    break;

                case 2:
                    Console.Write("Enter Account Number: ");    // Get account number from user
                    string accNo = Console.ReadLine();
                    Bank acc = bankSystem.GetAccount(accNo); // Find account using account number

                    if (acc == null)
                        Console.WriteLine("Account not found."); // Check if account is found
                    else
                    {
                        Console.WriteLine("Name: " + acc.UserName); // Display account details
                        Console.WriteLine("Account Number: " + acc.AccountNumber); // Display account details
                        Console.WriteLine("Balance: " + acc.Balance); // Display account details
                    }
                    break;

                case 3:
                    Console.WriteLine("Manager logged out.");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        } while (choice != 3);
    }
}

class Program
{
    static void Main()
    {
        BankSystem bankSystem = new BankSystem(); //     Create BankSystem object
        Manager manager = new Manager(bankSystem); // Create Manager object
        User user = new User(bankSystem); // Create User object

        int role;
        do
        {
            Console.WriteLine("\n=== WELCOME TO BANK ==="); 
            Console.WriteLine("1. Manager"); // Display options for user
            Console.WriteLine("2. User");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your role: ");

            role = Convert.ToInt32(Console.ReadLine());

            switch (role)
            {
                case 1:
                    manager.ManagerMenu(); // Call manager menu 
                    break;

                case 2:
                    user.UserMenu(); // Call user menu
                    break; 

                case 3:
                    Console.WriteLine("Bank system closed."); // Exit program
                    break;

                default:
                    Console.WriteLine("Invalid option."); // Invalid option
                    break;
            }

        } while (role != 3); // Loop until user chooses to exit
    }
}