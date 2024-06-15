// using System;
// using System.ComponentModel;

// class ArrayOperations
// {
//     public static void ArrayMatrixOperations()
//     {
//         // Prompt the user to enter the number of rows and columns
//         Console.WriteLine("Enter the number of rows:");
//         int rows = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine("Enter the number of columns:");
//         int columns = Convert.ToInt32(Console.ReadLine());

//         // Declare the 2D array (matrix)
//         int[,] matrix1 = new int[rows, columns];
//         int[,] matrix2 = new int[rows, columns];

//         // Loop to take input for each element of the matrix1
//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < columns; j++)
//             {
//                 Console.Write($"Enter element at position ({i}, {j}): ");
//                 matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
//             }
//         }
//         // Loop to take input for each element of the matrix2
//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < columns; j++)
//             {
//                 Console.Write($"Enter element at position ({i}, {j}): ");
//                 matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
//             }
//         }
//         Console.WriteLine("Thanks for Entering the Data for Two Matrix:");

//         Console.WriteLine("1. Addition of two matrices");
//         Console.WriteLine("2. Subtraction of two matrices");
//         Console.WriteLine("3. Multiplication of two matrices");
//         Console.WriteLine("4. Division of two matrices");
//         Console.WriteLine("5. Modulus of two matrix");
//         Console.WriteLine("6. Exit");
//         int n = Convert.ToInt32(Console.ReadLine());
//         int[,] result = null;
//         switch (n)
//         {
//             case 1:
//                 result = Add(matrix1, matrix2, rows, columns);
//                 PrintMatrix("Addition Result:", result);
//                 break;
//             case 2:
//                 result = Sub(matrix1, matrix2, rows, columns);
//                 PrintMatrix("Subtraction Result:", result);
//                 break;
//             case 3:
//                 result = Mult(matrix1, matrix2, rows, columns);
//                 PrintMatrix("Multiplication Result:", result);
//                 break;
//             case 4:
//                 result = Div(matrix1, matrix2, rows, columns);
//                 PrintMatrix("Division Result:", result);
//                 break;
//             case 5:
//                 result = Mod(matrix1, matrix2, rows, columns);
//                 PrintMatrix("Modulus Result:", result);
//                 break;
//             case 6:
//                 break;
//             default:
//                 Console.WriteLine("Wrong Input!");
//                 break;
//         }
//     }

//     public static int[,] Add(int[,] matrix1, int[,] matrix2, int rows, int columns)
//     {

//         int[,] resultAdd = new int[rows, columns];
//         // Loop to take input for each element of the matrix1
//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < columns; j++)
//             {
//                 resultAdd[i, j] = matrix1[i, j] + matrix2[i, j];
//             }
//         }
//         return resultAdd;
//     }
//     public static int[,] Sub(int[,] matrix1, int[,] matrix2, int rows, int columns)
//     {

//         int[,] resultSub = new int[rows, columns];
//         // Loop to take input for each element of the matrix1
//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < columns; j++)
//             {
//                 resultSub[i, j] = matrix1[i, j] - matrix2[i, j];
//             }
//         }
//         return resultSub;
//     }
//     public static int[,] Mult(int[,] matrix1, int[,] matrix2, int rows, int columns)
//     {

//         int[,] resultMult = new int[rows, columns];
//         // Loop to take input for each element of the matrix1
//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < columns; j++)
//             {
//                 resultMult[i, j] = matrix1[i, j] * matrix2[i, j];
//             }
//         }
//         return resultMult;
//     }
//     public static int[,] Div(int[,] matrix1, int[,] matrix2, int rows, int columns)
//     {

//         int[,] resultDiv = new int[rows, columns];
//         // Loop to take input for each element of the matrix1
//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < columns; j++)
//             {
//                 resultDiv[i, j] = matrix1[i, j] / matrix2[i, j];
//             }
//         }
//         return resultDiv;
//     }
//     public static int[,] Mod(int[,] matrix1, int[,] matrix2, int rows, int columns)
//     {

//         int[,] resultMod = new int[rows, columns];
//         // Loop to take input for each element of the matrix1
//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < columns; j++)
//             {
//                 resultMod[i, j] = matrix1[i, j] % matrix2[i, j];
//             }
//         }
//         return resultMod;
//     }
//     public static void PrintMatrix(string title, int[,] matrix)
//     {
//         Console.WriteLine(title);
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 Console.Write(matrix[i, j] + "\t");
//             }
//             Console.WriteLine();
//         }
//     }
// }
