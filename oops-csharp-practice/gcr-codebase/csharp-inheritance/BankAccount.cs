using System;

// Superclass
class BankAccount
{
    public string AccountNumber;
    public double Balance;
}

// Savings Account
class SavingsAccount : BankAccount
{
    public double InterestRate;

    public void DisplayAccountType()
    {
        Console.WriteLine("Account Type: Savings Account");
        Console.WriteLine("Account No: " + AccountNumber);
        Console.WriteLine("Balance: " + Balance);
        Console.WriteLine("Interest Rate: " + InterestRate + "%");
    }
}

// Checking Account
class CheckingAccount : BankAccount
{
    public int WithdrawalLimit;

    public void DisplayAccountType()
    {
        Console.WriteLine("Account Type: Checking Account");
        Console.WriteLine("Account No: " + AccountNumber);
        Console.WriteLine("Balance: " + Balance);
        Console.WriteLine("Withdrawal Limit: " + WithdrawalLimit);
    }
}

// Fixed Deposit Account
class FixedDepositAccount : BankAccount
{
    public int LockInPeriod; // in years

    public void DisplayAccountType()
    {
        Console.WriteLine("Account Type: Fixed Deposit Account");
        Console.WriteLine("Account No: " + AccountNumber);
        Console.WriteLine("Balance: " + Balance);
        Console.WriteLine("Lock-in Period: " + LockInPeriod + " years");
    }
}

class Program
{
    static void Main()
    {
        SavingsAccount sa = new SavingsAccount
        {

            AccountNumber = "SA101",
            Balance = 50000,
            InterestRate = 4.5
        };

        sa.DisplayAccountType();
    }
}
