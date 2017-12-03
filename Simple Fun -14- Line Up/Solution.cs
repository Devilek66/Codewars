namespace myjinxin
{
    using System;
    
    public class Kata
    {
        public int LineUp(string cmd){
          int student = 0;
          bool face=false;
          for(int i = 0; i<cmd.Length;i++)
          {
            if(cmd[i] == 'A' && face)
            {
              student++;
            }
            if((cmd[i] == 'R' || cmd[i] == 'L') && !face)
            {
              student++;
              face=true;
            }
              else
                if(cmd[i] == 'R' || cmd[i] == 'L')
                {
                  face = false;
                }
          }      
          return cmd.Length-student;
        }
    }
}
