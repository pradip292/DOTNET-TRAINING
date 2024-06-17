class RowsChange{
    public static int[,] Change_r(int[,] matrix, int rows, int columns,int first, int second){
        first--;
        second--;
        for(int j=0; j<columns;j++){
            
                int temp= matrix[first,j];
                matrix[first,j]=matrix[second,j];
                matrix[second,j]=temp;
            
            //Console.WriteLine();
        }
        return matrix;
    }
}