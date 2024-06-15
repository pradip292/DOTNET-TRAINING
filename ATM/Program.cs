using System;
using System.Net.Security;
using Microsoft.VisualBasic;

class Program
{
    static void Main()
    {   
        Account account = new Account("1234567890", "1234", 1000);
        int flag = 0;
        Console.WriteLine("Enter your PIN");
        string pin = Console.ReadLine();
        while (flag == 0)
        {
            if (account.ValidatePIN(pin))
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter amount to deposit");
                        double amount = Convert.ToDouble(Console.ReadLine());
                        account.Deposit(amount);
                        break;
                    case 2:
                        Console.WriteLine("Enter amount to withdraw");
                        amount = Convert.ToDouble(Console.ReadLine());
                        account.Withdraw(amount);
                        break;
                    case 3:
                        account.CheckBalance();
                        break;
                    case 4:
                        flag = 1;
                        Console.WriteLine("Thank you for using our services");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid PIN");
                break;
            }
        }



    }

}
