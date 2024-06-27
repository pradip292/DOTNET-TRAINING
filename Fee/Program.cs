using System;
class Program{
    public static void Main(String[] args){
         string collegeName = "SANJIVANI COLLEGE OF ENGINEERING";
        // Receipt details
        string academicTitle = "Academic Fee Receipt";
        string studentName = "PRADIP WARKHADE";
        string prnNo = "UIT21M1069";
        string className = "B.TECH IN IT";
        string year = "3rd Year";
        string dateTime = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
        string receiptNo = "RCPT78910";        
        // Fee categories and amounts
        string[] feeCategories = { "Tuition Fee", "Library Fee", "Lab Fee", "Sports Fee", "Miscellaneous" };
        decimal[] feeAmounts = { 1500.00m, 200.00m, 300.00m, 100.00m, 150.00m };
        
        // Calculate total amount
        decimal totalAmount = 0;
        foreach (decimal amount in feeAmounts)
        {
            totalAmount += amount;
        }

        // Printing the receipt
        Console.WriteLine(new string('-', 40));
        Console.WriteLine(collegeName.ToUpper().PadLeft((40 + collegeName.Length) / 2));
        Console.WriteLine(new string('-', 40));
        Console.WriteLine(academicTitle.PadLeft((40 + academicTitle.Length) / 2));
        Console.WriteLine(new string('-', 40));
        Console.WriteLine($"Student Name: {studentName}");
        Console.WriteLine($"PRN No: {prnNo}");
        Console.WriteLine($"Class: {className}");
        Console.WriteLine($"Year: {year}");
        Console.WriteLine($"Date & Time: {dateTime.PadLeft(40 - "Date & Time: ".Length)}");
        Console.WriteLine($"Receipt No: {receiptNo.PadLeft(40 - "Receipt No: ".Length)}");
        Console.WriteLine(new string('-', 40));
        
        // Printing fee categories and amounts
        for (int i = 0; i < feeCategories.Length; i++)
        {
            Console.WriteLine($"{feeCategories[i]}: {feeAmounts[i].ToString("C2").PadLeft(40 - (feeCategories[i].Length + 2))}");
        }
        
        Console.WriteLine(new string('-', 40));
        Console.WriteLine($"Total Amount: {totalAmount.ToString("C2").PadLeft(40 - "Total Amount: ".Length)}");
        Console.WriteLine(new string('-', 40));
        Console.WriteLine("""Thank you!""".PadLeft((40 + "Thank you!".Length) / 2));
        Console.WriteLine(new string('-', 40));
        

    }
}