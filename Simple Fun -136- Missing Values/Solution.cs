namespace myjinxin
{
    using System;
    using System.Linq;
    public class Kata
    {
        public int MissingValues(int[] arr){
          var query = arr.GroupBy(r => r)
                .Select(grp => new
                {
                    Value = grp.Key,
                    Count = grp.Count()
                });
          var x = query.First(item => item.Count == 1).Value;
          var y = query.First(item => item.Count == 2).Value;
          return x*x*y;
        }
    }
}
