using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.SOLID.InterfaceSegregationPrinciple.Interfaces
{
  public interface IProductRegister
  {
    void DataValidate();
    void Save();
  }
}
