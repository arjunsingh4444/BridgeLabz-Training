using System;

class Customer
{
    public string Name; // public property
    public int Balance;

    public void ViewBalance() // public method
    {
        Console.WriteLine("Balance: " + Balance); // accessing the public property
    }
}

class Bank
{
    public string BankName; // public property

    public void OpenAccount(Customer c) // public method
    {
        c.Balance = 1000; // setting the initial balance of the customer
        Console.WriteLine("Account opened for " + c.Name); //   
    }
}

class Program
{
    static void Main()
    {
        Bank bank = new Bank(); // creating an object of Bank class
        bank.BankName = "SBI";

        Customer c1 = new Customer(); // creating an object of Customer class
        c1.Name = "Arjun";

        bank.OpenAccount(c1); // calling the OpenAccount method of Bank class with c1 object as parameter
        c1.ViewBalance(); // calling the ViewBalance method of Customer class with c1 object as parameter
    }
}
