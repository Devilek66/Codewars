using System;
namespace CodeWars
{
    class Connect4
    {
      int[,] p = new int[6,7];
      int actualplayer = 1;
      bool notfinished=true;
        public string play(int col)
        {
          if(!notfinished)
          {
            return "Game has finished!";
          }
          if(Full(col))
            return "Column full!";
            Drop(col);
          for(int i=0; i<6; i++)
          {
            for(int j=0;j<7;j++)
            {
              Console.Write(p[i,j]);
            }
            Console.WriteLine("");
          }
          
          if(win()>0 && notfinished)
          {
            notfinished=false;
            return "Player "+win()+" wins!";
          }
          return "Player "+HasTurn()+" has a turn";
        }
        
        private int win()
        {
          if(CheckColumn() !=0) return CheckColumn();
          if(CheckRow() !=0) return CheckRow();
          if(CheckDiag() !=0) return CheckDiag();
          return 0;
        }
        
        private bool Full(int col) => (p[5,col] != 0) ? true : false;
        private void Drop(int col)
        {
          bool drop=true;
          int i=0;
          while(drop)
          {
            if(p[i,col]==0)
            {
              this.p[i,col]=actualplayer;
              drop=false;
            }
            i++;
          }
          ChangePlayer();
        }
        private void ChangePlayer() =>actualplayer= actualplayer==1 ? 2 : 1;
        private int HasTurn() => actualplayer==1 ? 2 : 1;
        private int CheckColumn()
        {
          int l = 0;
          int tmp = 0;
            for(int i=0;i<7;i++)
            {
              for(int j=0;j<6;j++)
              {
                if(tmp ==p[j,i] && p[j,i]!=0) l++;
                  else
                  {
                    l=1;
                    tmp=p[j,i];
                  }
                if(l==4) return tmp;
                
              }
            }
            return 0;
        }
        private int CheckRow()
        {
          int l = 0;
          int tmp = 0;
            for(int i=0;i<6;i++)
            {
              for(int j=0;j<7;j++)
              {
                if(tmp ==p[i,j] && p[i,j]!=0) l++;
                  else
                  {
                    l=1;
                    tmp=p[i,j];
                  }
                if(l==4) return tmp;
                
              }
            }
            return 0;
        }
        private int CheckDiag()
        {
          int l = 0;
          int tmp = 0;
          int x=0,y=0;
          for(int i=0;i<6;i++)
          {
            for(int j=0;j<i+1;j++)
            {
              if(tmp ==p[i-j,j] && p[i-j,j]!=0) l++;
                  else
                  {
                    l=1;
                    tmp=p[i-j,j];
                  }
                  Console.WriteLine(p[i-j,j]);//not ended, sorry but its get clear ;)
                if(l==4) return tmp;
            }
            l=1;
          }
          return 0;
        }
    }
}
