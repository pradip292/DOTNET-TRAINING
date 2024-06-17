class ColumnsChange{
    public static int[,] Change_c(int[,] matrix, int rows, int columns,int first, int second){
        first--;
        second--;
        for(int i=0; i<rows;i++){
            
                int temp= matrix[i,first];
                matrix[i,first]=matrix[i,second];
                matrix[i,second]=temp;
            
            //Console.WriteLine();
        }
        return matrix;

    }
}