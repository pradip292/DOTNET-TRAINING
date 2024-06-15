using System;
class Account
{
    public string AccNumber { get; set; }
    private string PIN { get; set; }
    private double Balance { get; set; }
    public Account(string accNumber, string pin, double balance)
    {
        AccNumber = accNumber;
        PIN = pin;
        Balance = balance;
    }
    public bool ValidatePIN(string pin)
    {
        return PIN == pin;
    }
    public void Deposit(double amount)
    {
        Balance += amount;
    }
    public void CheckBalance()
    {
        Console.WriteLine($"Your balance is {Balance}");
    }
    public void Withdraw(double amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine("Insufficient funds");
        }
        else
        {
            Balance -= amount;
        }
    }
}