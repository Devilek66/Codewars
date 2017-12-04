namespace myjinxin
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Kata
    {
        public int MostFrequentDigitSum(int n){
          int tmp=0;
          List<int> list = new List<int>();
          while(n>0)
          {
            for(int i =0;i<n.ToString().Length;i++)
            {
              tmp+=Convert.ToInt32(n.ToString()[i].ToString());
            }
            list.Add(tmp);
            n=n-tmp;
            tmp=0;
          }
          return list.OrderByDescending(grp=>grp).GroupBy(i=>i).OrderByDescending(grp=>grp.Count()).Select(grp=>grp.Key).First();
        }
    }
}
