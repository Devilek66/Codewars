using System;
using System.Linq;
public class Kata
{
  public static long SuperSize(long num) => Convert.ToInt64(String.Concat(num.ToString().OrderByDescending(c => c)));
}
