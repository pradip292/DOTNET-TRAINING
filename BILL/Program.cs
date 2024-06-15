using System;

struct Record
{
    public string ItemName;
    public int Quantity;
    public float Price;
}

class Program
{
    static void Main()
    {
        const float GstRate = 0.18f; // 18% GST

        Console.Write("Enter the hotel name: ");
        string hotelName = Console.ReadLine();

        Console.Write("Enter the GST number: ");
        string gstNumber = Console.ReadLine();

        Console.Write("Enter the number of records: ");
        int recordCount = int.Parse(Console.ReadLine());

        Record[] records = new Record[recordCount];

        // Input records
        for (int i = 0; i < recordCount; i++)
        {
            Console.WriteLine($"\nEnter details for item {i + 1}:");

            Console.Write("Item Name: ");
            records[i].ItemName = Console.ReadLine();

            Console.Write("Quantity: ");
            records[i].Quantity = int.Parse(Console.ReadLine());

            Console.Write("Price: ");
            records[i].Price = float.Parse(Console.ReadLine());
        }

        // Print the formatted bill
        float grandTotal = 0;
        Console.WriteLine("\n\n" + hotelName);
        Console.WriteLine("GST Number: " + gstNumber);
        Console.WriteLine("Date & Time: " + DateTime.Now);
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("{0,-20} {1,-10} {2,-10} {3,-10}", "Item Name", "Quantity", "Price", "Total");
        Console.WriteLine("------------------------------------------------------------");
        for (int i = 0; i < recordCount; i++)
        {
            float total = records[i].Quantity * records[i].Price;
            grandTotal += total;
            Console.WriteLine("{0,-20} {1,-10} {2,-10} {3,-10}", records[i].ItemName, records[i].Quantity, records[i].Price, total);
        }
        Console.WriteLine("------------------------------------------------------------");

        float gstAmount = grandTotal * GstRate;
        float totalAmount = grandTotal + gstAmount;

        Console.WriteLine("{0,-20} {1,-10} {2,-10} {3,-10}", "Subtotal", "", "", grandTotal);
        Console.WriteLine("{0,-20} {1,-10} {2,-10} {3,-10}", "GST (18%)", "", "", gstAmount);
        Console.WriteLine("{0,-20} {1,-10} {2,-10} {3,-10}", "Total", "", "", totalAmount);
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("\nThank you for dining with us!");
    }
}
