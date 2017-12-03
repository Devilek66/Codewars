using System;
using System.Linq;
public static class Kata
{
  public static long CountZeroes(int n)
  {
    return (n<2) ? 0 : n==2 ? 9 : Convert.ToInt64((n-2).ToString() + String.Concat(Enumerable.Repeat("8", n-2)) + "9");
  }
}
