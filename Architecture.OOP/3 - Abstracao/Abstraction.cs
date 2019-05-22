using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.OOP
{
  public abstract class Eletrodomestico
  {
    private readonly string _name;
    private readonly int _voltage;

    protected Eletrodomestico(string name, int voltage)
    {
      _name = name;
      _voltage = voltage;
    }

    public abstract void TurnOn();
    public abstract void Off();
  }
}
