using System;
class Arge {
    public static int NbYear(int p0, double percent, int aug, int p) {
        double pp=p0;
        int l=0;;
        while(pp<p)
        {
          pp=Math.Floor(pp+pp*percent/100+Convert.ToDouble(aug));
          l++;
        }
        return l; 
    }
}
