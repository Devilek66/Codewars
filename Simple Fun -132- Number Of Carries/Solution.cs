namespace myjinxin
{
    using System;
    
    public class Kata
    {
        public int NumberOfCarries(int a, int b){
          int tmp=0,aa=a,bb=b,l=0;
          while(aa>0 || bb>0)
          {
            if(aa%10+bb%10+tmp >=10)
            {
              l++;
              tmp=1;
            }
            else
              tmp=0;
            aa/=10;
            bb/=10;
          }
          return l;
        }
    }
}
