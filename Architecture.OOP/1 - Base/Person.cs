using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.OOP
{
  public class Person
  {
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }

    public int CalculateAge()
    {
      var atualDate = DateTime.Now;
      var age = atualDate.Year - DateOfBirth.Year;

      if (atualDate < DateOfBirth.AddYears(age))
        age--;

      return age;
    }
  }
}
