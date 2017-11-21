using System;

public static class Kata
{
  public static string TimeConvert(int num) => (num<=0) ? "00:00" : (num/60).ToString().PadLeft(2, '0')+":"+(num%60).ToString().PadLeft(2, '0');
}
