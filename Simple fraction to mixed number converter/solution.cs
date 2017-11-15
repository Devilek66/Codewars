using System;
public class Kata
{
  public static string MixedFraction(string s)
  {
    int[] liczby = GetNumbers(s);
    int[] shorten = Shorten(liczby[0],liczby[1]);
    int[] enddiv = EndDiv(shorten[0],shorten[1]);
    if(IsNegative(liczby[0],liczby[1]))
      return "-"+EndString(enddiv[0],enddiv[1],shorten[1]);
    else
      return EndString(enddiv[0],enddiv[1],shorten[1]);
  }
  private static int[] GetNumbers(string s)
  {
    int[] liczby = new int[2];
    string tmp="";
    for(int i=0;i<s.Length;i++)
    {
      if(s[i]!='/')
        tmp+=s[i];
      else
      {
        liczby[0]=Convert.ToInt32(tmp);
        tmp="";
      }
    }
    liczby[1]=Convert.ToInt32(tmp);
    return liczby;
  }
  private static int GCD(int a, int b)
  {
    return b == 0 ? a : GCD(b, a % b);
  }
  private static int[] Shorten(int a, int b)
  {
    int[] shorten = new int[2];
    shorten[0]=a/GCD(a,b);
    shorten[1]=b/GCD(a,b);
    return shorten;
  }
  private static int[] EndDiv(int a,int b)
  {
    int[] output = new int[2];
    output[0]=a/b;
    output[1]=a%b;
    return output;
  }
  private static string EndString(int a,int b,int c)
  {
    string output="";
    if(a!=0)
    {  
      output+=Math.Abs(a).ToString();
      if(b!=0)
      {
        output+=" "+Math.Abs(b).ToString()+"/"+Math.Abs(c).ToString();
      }
    }
    else
    {
      if(b!=0)
      {
        output+=Math.Abs(b).ToString()+"/"+Math.Abs(c).ToString();
      }
    }
    if(output=="")
      output="0";
    return output;
  }
  private static bool IsNegative(int a,int b)
  {
    if(a<=0 && b<=0)
      return false;
    if(a<0)
      return true;
    else
      if(b<0)
        return true;
    return false;
  }
}
