using System;

public static class Kata
{
  public static int MinDistance(int n)
  {
    int min=n-1,one=0,sec=0;
    for(int i=1;i<n;i++)
    {
      if(n%i == 0)
      {
        if(one==0)
          one = i;
        else
        {
          sec = one;
          one = i;
        }
      }
      if(one!=0 && sec!=0)
        if(one-sec<min) min=one-sec;
    }
    return min;
  }
}
