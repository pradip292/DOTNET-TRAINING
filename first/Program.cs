using System;
using System.Net.Security;
using Microsoft.VisualBasic;

class Program
{
    static void Main()
    {
        /*
        // Example  of Boxing
        int valueType = 123;      // Value type
        object boxedValue = valueType;  // Boxing: Converting value type to object type

        Console.WriteLine("Boxing:");
        Console.WriteLine("Value type: " + valueType);
        Console.WriteLine("Boxed value: " + boxedValue);

        // Example of Unboxing
        object obj = 456;         // Boxed value
        int unboxedValue = (int)obj; // Unboxing: Converting object type back to value type

        Console.WriteLine("\nUnboxing:");
        Console.WriteLine("Object type: " + obj);
        Console.WriteLine("Unboxed value: " + unboxedValue);

        // Another example with double
        double doubleValue = 78.9; // Value type
        object boxedDouble = doubleValue; // Boxing

        Console.WriteLine("\nBoxing double:");
        Console.WriteLine("Double value: " + doubleValue);
        Console.WriteLine("Boxed double: " + boxedDouble);

        double unboxedDouble = (double)boxedDouble; // Unboxing
        Console.WriteLine("\nUnboxing double:");
        Console.WriteLine("Object type: " + boxedDouble);
        Console.WriteLine("Unboxed double: " + unboxedDouble);
        */


        //////////////////////////////////////////////////////////
        /*
        int a= 5;
        int b=a;
        Console.WriteLine("Assign the valued: "+b);
        int c=1;
        a+=c;
        Console.WriteLine("After increment the value is: "+ a);

        */

        //write a c# program 
        /*
        // write a program based on boxing and unboxing
        int num = 9;
        object obj = num;

        int num1 = 1;
        object obj1 = num1;

        int num2 = 2;
        object obj2 = num2;

        object unbox = "suyog";
        string str = (string)unbox;

        object unbox1 = "gaurav";
        string str1 = (string)unbox1;

        object unbox2 = "ritesh";
        string str2 = (string)unbox2;

        Console.WriteLine("Enter the roll number");
        int a = Convert.ToInt32(Console.ReadLine());

        if (a == 9)
        {
            Console.WriteLine("roll no is : " + obj + " & name is : " + str);
        }
        else if (a == 1)
        {
            Console.WriteLine("roll no is : " + obj1 + "& name is : " + str1);
        }
        else if (a == 2)
        {
            Console.WriteLine("roll no is : " + obj2 + "& name is : " + str2);
        }
        else
        {
            Console.WriteLine("invalid roll number");
        }
        


        // Patterns
        int n;

        // Asking the user to enter the number of rows
        Console.Write("Enter the number of rows: ");
        string input = Console.ReadLine();

        // Try to parse the input
        while (!int.TryParse(input, out n) || n <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
            input = Console.ReadLine();
        }

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
        

        int n;

        // Asking the user to enter the number of rows
        Console.Write("Enter the number of rows: ");
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }

        for (int i = n; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
        
         int n;

        // Asking the user to enter the number of rows
        Console.Write("Enter the number of rows: ");
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }

        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j < n; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= (2 * i - 1); k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        */
        // double area,l,h;
        // Console.WriteLine("Enter the Length:");
        // l = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Enter the Height:");
        // h = Convert.ToInt32(Console.ReadLine());
        // area = 0.5 * l * h;
        // Console.WriteLine("The area of the triangle is: "+area);

        
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
