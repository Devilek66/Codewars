namespace myjinxin
{
    using System;
    
    public class Kata
    {
        public int[][] ReverseOnDiagonals(int[][] matrix){
          int[][] output = new int[matrix.Length][];
          int tmp=0;
          for(int i=0;i<matrix.Length/2;i++)
          {
            tmp = matrix[i][i];
            matrix[i][i] = matrix[matrix.Length-1-i][matrix.Length-1-i];
            matrix[matrix.Length-1-i][matrix.Length-1-i] = tmp;
            tmp = matrix[i][matrix.Length-1-i];
            matrix[i][matrix.Length-1-i] = matrix[matrix.Length-1-i][i];
            matrix[matrix.Length-1-i][i] = tmp;
          }
          return matrix;
        }
    }
}
