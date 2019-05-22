using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.OOP
{
  public class CoffeeAutomation
  {
    public void ServeCoffee()
    {
      var express = new ExpressCoffeeMachine();
      express.TurnOn();
      express.MakeCoffee();
      express.Off();
    }
  }
}
