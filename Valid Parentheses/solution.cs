using System;
using System.Text.RegularExpressions;
public class Parentheses
{
    public static bool ValidParentheses(string input)
    {
        int l=input.Length;
        string z=input;
        z=Regex.Replace(z, "[A-Za-z ]", "");
        do{
          if(l!=z.Length) 
            l=z.Length;
          z=z.Replace("()", "");
        }while(l!=z.Length);
        if(z.Length == 0)
          return true;
        else 
          return false;
    }
}
