using System;

public class MovieC {
    
    public static int Movie(int card, int ticket, double perc) {
          double withcard = card,without = 0,p=perc;
          while(Math.Ceiling(withcard)>=without)
          {
            withcard+=ticket*p;
            p=p*perc;
            without+=ticket;
          }
          return Convert.ToInt32(without/ticket);
    }
}
