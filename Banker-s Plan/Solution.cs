using System;
public class BankerPlan {
    
    public static Boolean Fortune(int f0, double p, int c0, int n, double i) {
        double pp=p/100,ip=i/100, f=Convert.ToDouble(f0),c=Convert.ToDouble(c0);
        Console.WriteLine(Math.Truncate(pp));
        for(int j=1;j<n;j++)
        {
          f= f + f* pp - c;
          c= c+c*ip;
        }
        if(f>0) return true;
        else return false;
    }
    
    
}
