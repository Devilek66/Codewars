public class Kata
{
  public static uint Hotpo(uint n)
  {
    uint output=0,n2=n;
    while(n2!=1)
    {
      if(n2%2 == 0)
      n2=n2/2;
      else
      n2=n2*3+1;
      output++;
    }
    return output;
  }
}
