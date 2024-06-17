using System;
using System.Drawing;

class Program
{
    public static void Main(string[] args)
    {
        /*
        Console.WriteLine("Enter the matrix data:");
        Console.WriteLine("Enter the number of rows: ");
        int rows= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the number of columns: "); 
        int columns= Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[rows, columns];
        Console.WriteLine("Enter the elements of the matrix: ");
        for(int i=0;i<rows;i++){
            for(int j=0;j<columns;j++){
                matrix[i,j]= Convert.ToInt32(Console.ReadLine());
            }
        }
        */

        /* Transpose
        int[,] transpose= Transpose.show_transpose(matrix,rows,columns);

        for(int i=0;i<rows;i++){
            for(int j=0;j<columns;j++){
                Console.Write(transpose[i,j]+" ");
            }
            Console.WriteLine();
        }
        */

        /* Column Exchange
        Console.WriteLine("Enter the no of first column to exchange:");
        int first = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the no of second column to exchange:");
        int second = Convert.ToInt32(Console.ReadLine());
        int[,] new_c = ColumnsChange.Change_c(matrix,rows,columns,first,second);

        for(int i=0;i<rows;i++){
            for(int j=0;j<columns;j++){
                Console.Write(new_c[i,j]);
            }
            Console.WriteLine();
        }
        */

        /* Rows Exchange
        Console.WriteLine("Enter the no of first rows to exchange:");
        int first = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the no of second rows to exchange:");
        int second = Convert.ToInt32(Console.ReadLine());
        int[,] new_c = RowsChange.Change_r(matrix,rows,columns,first,second);

        for(int i=0;i<rows;i++){
            for(int j=0;j<columns;j++){
                Console.Write(new_c[i,j]);
            }
            Console.WriteLine();
        }
        */
        
        /* String Concatenation
        Console.WriteLine("Enter the first string:");
        string firstString = Console.ReadLine();

        Console.WriteLine("Enter the second string:");
        string secondString = Console.ReadLine();

        string concatenatedString = StringConcatenation.Concatenate(firstString, secondString);

        Console.WriteLine("The concatenated string is:");
        Console.WriteLine(concatenatedString);
        */

        /* element in a array
        int[] numbers = { 64, 34, 25, 12, 22, 11, 90 };

        Console.WriteLine("Enter the number to search:");
        int target = Convert.ToInt32(Console.ReadLine());

        int index = Element.LinearSearch(numbers, target);

        if (index != -1)
        {
            Console.WriteLine($"Element {target} found at index {index}");
        }
        else
        {
            Console.WriteLine($"Element {target} not found in the array");
        }
        */

    }
}
