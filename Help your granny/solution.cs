using System.Collections;
using System;
public class Tour
        {
            public static int tour(string[] arrFriends, string[][] ftwns, Hashtable h)
            {
                string symbolH=(ftwns[0][1])[0].ToString();
                string symbolF=((arrFriends[0])[0].ToString());
                double sum=0;
                string actual= "X0";
                for(int i=1;i<ftwns.Length+1;i++)
                {
                  if(isFriend(arrFriends,symbolF+i.ToString()))
                  {
                    if(actual=="X0")
                    {
                      actual=symbolH+i.ToString();
                      sum+=Convert.ToDouble(h[actual]);
                    }
                    else
                    {
                      sum+=distance(actual,symbolH+i.ToString(),h);
                      actual=symbolH+i.ToString();
                    }
                  }
                }
                sum+=Convert.ToInt64(h[actual]);
                return Convert.ToInt32(Math.Floor(sum));
            }
            
            private static double distance(string x,string x2, Hashtable h)
            {
                double a=0,b=0,c=0;
                a=Convert.ToDouble(h[x])*Convert.ToDouble(h[x]);
                b=Convert.ToDouble(h[x2])*Convert.ToDouble(h[x2]);
                c=Convert.ToDouble(Math.Sqrt(b-a));
                return c;
            }
            private static bool isNext(string x,string x2)
            {
                if((Convert.ToDouble(x[1]))<Convert.ToDouble(x2[1]))
                return true;
                else
                return false;
            }
            private static bool isFriend(string[] arrFriends, string x)
            {
              for(int i =0; i<arrFriends.Length; i++)
              {
                if(arrFriends[i]==x)
                return true;
              }
              return false;
            }
        }
