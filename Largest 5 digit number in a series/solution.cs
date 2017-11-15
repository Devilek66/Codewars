using System;

public class Kata 
{
  public static int GetNumber(string str) 
  {
    int max=0;
    int tmp=0;
    for(int i=0;i<str.Length-4;i++)
    {
      tmp=Int32.Parse(str.Substring(i,5));
      if(tmp>max)
      max=tmp;
    }
    
    return max;
  }
}
