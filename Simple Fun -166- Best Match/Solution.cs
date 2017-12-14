namespace myjinxin
{
    public class Kata
    {
        public int BestMatch(int[] goals1, int[] goals2){
          int dif=100,pos=0,goal=0;
          for(int i =0;i<goals1.Length;i++)
          {
            if(goals1[i]-goals2[i]<dif)
            {
              dif = goals1[i]-goals2[i];
              goal=goals2[i];
              pos=i;
            }
            if(goals1[i]-goals2[i]==dif && goal<goals2[i])
            {
              goal = goals2[i];
              pos=i;
            }
          }
          return pos;
        }
    }
}
