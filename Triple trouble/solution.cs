using System;
using System.Collections.Generic;

public class Kata
{
  public static int TripleDouble(long num1, long num2)
  {
    int tmp=num(num1,2);
    if(tmp==num(num2,1,tmp) && (tmp !=10))
    return 1;
    else
    return 0;
  }
  private static int num(long num1,int b,int c=10)
  {
    int tmp=num1.ToString().Length;
    int nr=10,countt=0,f=10;
    long tmp2=num1;
    for(int i=0;i<tmp;i++)
    {
      if(nr==(int)(tmp2%10))
      countt++;
      else
      {
      nr=(int)(tmp2%10);
      countt=0;
      }
      tmp2=tmp2/10;
      if(countt==b)
      {
      f=nr;
      if(nr==c)
      i=tmp;
      }
    }
    return f;
  }
  
  
}
