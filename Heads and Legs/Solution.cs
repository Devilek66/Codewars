public class Kata
{
  public static object Animals(int heads, int legs)
  {
    if((heads<0 || legs < 0) || (heads == 0 && legs!=0) || (legs==0 && heads!=0) || legs%2==1 || heads*2 > legs || heads*4 <legs) return "No solutions";
    return new int[] {heads-(legs-heads*2)/2, heads-(heads-(legs-heads*2)/2) };
  }
}
