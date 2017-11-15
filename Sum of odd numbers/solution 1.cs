using System;
public static class Kata
{
  public static long rowSumOddNumbers(long n)
  {
    long suma=0;
    long liczba=n*(n-1)+1;
    if(n==1)
      return 1;
    else
      for(long i=0; i<n;i++)
      {
        suma+=liczba+(i*2);
      }
      return suma;
  }
}
