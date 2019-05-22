using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.OOP
{
  public class ExpressCoffeeMachine : Eletrodomestico
  {
    public ExpressCoffeeMachine(string name, int voltage)
      :base(name, voltage){ }

    public ExpressCoffeeMachine()
      :base("Pattern", 220){ }

    public override void Off()
    {
      //resfriar aquecedor
    }

    public override void TurnOn()
    {
      //verificar recipiente de água
    }

    private static void HeatWater()
    {

    }

    private static void GrindingGrain()
    {

    }

    public void MakeCoffee()
    {
      HeatWater();
      GrindingGrain();
    }
  }
}
