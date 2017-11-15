using System;
public class Number
{
  public int DigitalRoot(long n)
  {
    long suma;
    long tmp;
    long nn=n;
    do
    {  //199
      suma=0;
      tmp= nn.ToString().Length;
      for(int i=0;i<tmp;i++)
      {
        suma+=nn%10;   //9
        nn=nn/10;      //19
      }
      nn=suma;
    }
    while(suma>9);
    return (int)suma;
  }
}
