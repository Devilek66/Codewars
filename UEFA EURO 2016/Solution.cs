public class Kata
{
  public static string UefaEuro2016(string[] teams, int[] scores)
  {
    string front="At match "+teams[0]+" - "+teams[1]+", ";
    return scores[0]>scores[1] ? front + teams[0] + " won!" : scores[0]==scores[1] ? front + "teams played draw." : front + teams[1] + " won!";
  }
}
