using System;
public class BackWardsPrime {
	
	public static string backwardsPrime(long start, long end) {
    string output="";
    for(long i = start; i<end+1;i++) if(isPrime(i)) output+=i.ToString()+" ";
    return output.Length>0 ? output.Remove(output.Length - 1) : "";
	}
  private static long revers(long x)
  {
    char[] chararray= x.ToString().ToCharArray();
    Array.Reverse(chararray);
    return Convert.ToInt64(new string(chararray));
  }
  private static bool isPrime(long x)
  {
    if(x<10 || x==revers(x)) return false;
    for(long j=2;j<=Math.Ceiling(Math.Sqrt(x));++j) if(x%j == 0) return false;
    for(long j=2;j<=Math.Ceiling(Math.Sqrt(revers(x)));++j) if(revers(x)%j == 0) return false;
    return true;
  }
}
