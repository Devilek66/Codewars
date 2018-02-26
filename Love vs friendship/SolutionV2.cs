using System;
using System.Linq;
public static class Kata
{
  public static int WordsToMarks(string str) => str.Sum(c => c - 96);
}
