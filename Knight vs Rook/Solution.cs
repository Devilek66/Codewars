using System;

public class KnightRook
    {
        public static string KnightVsRook(object[] knightPosition, object[]rookPosition)
        {
            int[] r = new int[]{Convert.ToInt32(rookPosition[0]),Convert.ToInt32(Convert.ToChar(rookPosition[1]))-64};
            int[] k = new int[]{Convert.ToInt32(knightPosition[0]),Convert.ToInt32(Convert.ToChar(knightPosition[1]))-64};
            if(r[0] == k[0] || k[1] == r[1]) return "Rook";
            if(Math.Abs(r[0]-k[0]) == 2 && Math.Abs(r[1]-k[1]) == 1 || Math.Abs(r[1]-k[1]) == 2 && Math.Abs(r[0]-k[0]) == 1) return "Knight";
            return "None";
        }
    }
