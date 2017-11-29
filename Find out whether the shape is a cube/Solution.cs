namespace CubeCheck {
  using System;
  public class CubeChecker
  {
    public bool IsCube(double volume, double side) => side<=0 ? false : side*side*side==volume ? true : false;
  }
}
