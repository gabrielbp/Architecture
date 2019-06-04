using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.SOLID.LiskovSubstitutionPrinciple
{
  public abstract class Paralelogramo
  {
    protected Paralelogramo(double length, double width)
    {
      Length = length;
      Width = width;
    }

    public double Length { get; private set; }
    public double Width { get; private set; }
    public double Area { get { return Length * Width; } }
  }
}
