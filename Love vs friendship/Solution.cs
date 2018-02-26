using System;

public static class Kata
{
  public static int WordsToMarks(string str)
  {
    int sum=0;
    foreach(char s in str) sum+=Convert.ToInt32(s)-96;
    return sum;
  }
}
