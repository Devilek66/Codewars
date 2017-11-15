using System;
public class Sudoku
{
  public static string DoneOrNot(int[][] board)
  {
    return ItsOk(board);
  }
  private static bool CheckRow(int[] row)
  {
    for(int i=0;i<9;i++)
    {
      for(int j=i+1;j<9;j++)
      {
        if(row[i]==row[j] || row[i]==0)
        return false;
      }
    }
    return true;
  }
  
  private static bool CheckColumn(int[][] column,int n)
  {
    int[] tmp=new int[9]; 
    for(int i=0;i<9;i++)
    {
      tmp[i]=column[i][n];
    }
    return CheckRow(tmp);
  }
  private static bool CheckRegions(int[][] region)
  {
    int[] tmp= new int[9];
    for(int r=0;r<9;r=r+3)
    {
      for(int g=0;g<9;g=g+3)
      {
        for(int i=0;i<3;i++)
        {
          for(int j=0;j<3;j++)
          {
            tmp[i*3+j]=region[i+r][j+g];
          }
        }
        if(!(CheckRow(tmp)))
        return false;
      }
    }
    return true;
  }
  private static string ItsOk(int[][] board)
  {
    for(int i =0;i<9;i++)
    {
      if(!CheckColumn(board,i) || !CheckRow(board[i]))
      return "Try again!";
    }
    if(!CheckRegions(board))
    return "Try again!";
    else return "Finished!";
  }
}
