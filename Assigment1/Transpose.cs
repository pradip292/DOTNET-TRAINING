class Transpose{
    public static int[,] show_transpose(int[,] matrix, int rows, int columns) {
        int[,] trans = new int[columns,rows];
        for(int i=0;i<rows;i++){
            for(int j=0;j<columns;j++){
                trans[j,i]= matrix[i,j];
        }
        }
        //Console.WriteLine("The Transpose Matrix is:")
        return trans;
    }
        
}