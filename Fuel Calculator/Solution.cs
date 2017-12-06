using System;
public class Kata
{
  public static double FuelPrice(double litres, double pricePerLiter) => litres<10 ? Math.Round(litres*pricePerLiter - Math.Floor(litres/2)*0.05*litres,2) : Math.Round(litres*pricePerLiter - litres*0.25,2);
}
