using System;
public class HQ9
{
  public static string Interpret(string code)
  {
    if(code=="H") return "Hello World!";
    if(code=="Q") return code;
    if(code!="9") return null;
      else
      {
      string lyrics="99 bottles of beer on the wall, 99 bottles of beer.\nTake one down and pass it around, ";
      string ii;
      for(int i=98;i>0;i--)
      { 
        if(i!=1)
        {
          ii=i.ToString();
          lyrics+=ii+" bottles of beer on the wall.\n"+ii+" bottles of beer on the wall, "+ii+" bottles of beer.\nTake one down and pass it around, ";
        }
        else
        {
          lyrics+="1 bottle of beer on the wall.\n1 bottle of beer on the wall, 1 bottle of beer.\nTake one down and pass it around, ";
        }
      }
      lyrics+="no more bottles of beer on the wall.\nNo more bottles of beer on the wall, no more bottles of beer.\nGo to the store and buy some more, 99 bottles of beer on the wall.";
      return lyrics;
    }
  }
}
