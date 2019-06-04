using System;

namespace Architecture.SOLID.LiskovSubstitutionPrinciple
{
  public class Quadrate : Paralelogramo
  {
    public Quadrate(double length, double width) 
      : base(length, width)
    {
      if (length != width)
        throw new ArgumentException("Os dois lados do quadrado precisam ser iguais");
    }
  }
}
