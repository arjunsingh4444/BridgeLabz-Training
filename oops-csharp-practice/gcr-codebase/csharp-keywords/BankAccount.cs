using System;

class BankAccount
{
    // static variable (shared by all accounts)
    static string bankName = "ABC Bank";
    static int totalAccounts = 0;

    // readonly variable (cannot change once assigned)
    readonly int AccountNumber;

    string AccountHolderName;

    // Constructor
    public BankAccount(string name, int accNo)
    {
        this.AccountHolderName = name;   // using this
        this.AccountNumber = accNo;
        totalAccounts++;
    }

    // static method
    public static void GetTotalAccounts()
    {
        Console.WriteLine("Total Accounts: " + totalAccounts);
    }

    public void Display(object obj)
    {
        // is operator
        if (obj is BankAccount)
        {
            Console.WriteLine("Bank: " + bankName);
            Console.WriteLine("Name: " + AccountHolderName);
            Console.WriteLine("Account No: " + AccountNumber);
        }
    }

    static void Main()
    {
        BankAccount acc1 = new BankAccount("Arjun", 101);
        acc1.Display(acc1);
        GetTotalAccounts();
    }
}
