namespace myjinxin
{
    using System;
    using System.Linq;
    public class Kata
    {
        public bool HigherVersion(string ver1, string ver2){
          int[] r1 = ver1.Split('.').Select(int.Parse).ToArray();
          int[] r2 = ver2.Split('.').Select(int.Parse).ToArray();
          for(int i=0;i<r1.Length;i++)
          {
            if(r1[i]!=r2[i])
            {
              return r1[i]>r2[i] ? true : false;
            }
          }     
          return false;
        }
    }
}
