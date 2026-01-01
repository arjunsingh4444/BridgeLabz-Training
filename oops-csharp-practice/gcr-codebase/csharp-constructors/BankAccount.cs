using System;

class BankAccount
{
    // Public
    public int accountNumber;

    // Protected
    protected string accountHolder;

    // Private
    private double balance;

    // Setter for balance
    public void SetBalance(double amount)
    {
        balance = amount;
    }

    // Getter for balance
    public double GetBalance()
    {
        return balance;
    }
}

// Subclass
class SavingsAccount : BankAccount
{
    public void SetAccountDetails(int accNo, string holder)
    {
        accountNumber = accNo;   // public
        accountHolder = holder; // protected
    }

    public void Display()
    {
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Account Holder: " + accountHolder);
    }
}

class Program
{
    static void Main()
    {
        SavingsAccount sa = new SavingsAccount();
        sa.SetAccountDetails(1111, "Arjun");
        sa.SetBalance(10000);

        sa.Display();
        Console.WriteLine("Balance: " + sa.GetBalance());
    }
}
