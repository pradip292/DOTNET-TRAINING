class JaggedArray
{
    public static void Solution()
    {
        Console.WriteLine("Hello World form Jagged Array!");
        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[] { 1, 2, 3 };
        jaggedArray[1] = new int[] { 4, 5 };
        jaggedArray[2] = new int[] { 6, 7, 8, 9 };

        // Accessing elements
        Console.WriteLine(jaggedArray[0][0]); // Output: 1
        Console.WriteLine(jaggedArray[1][1]); // Output: 5
        Console.WriteLine(jaggedArray[2][3]); // Output: 9

        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }


    }
}