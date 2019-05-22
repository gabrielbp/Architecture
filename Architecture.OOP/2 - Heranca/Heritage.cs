using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.OOP
{
  public class Employee : Person
  {
    public DateTime AdmissionDate { get; set; }
    public string Register { get; set; }
  }

  public class Process
  {
    public void Execution()
    {
      var employee = new Employee()
      {
        Name = "JOão",
        DateOfBirth = Convert.ToDateTime("1990/01/01"),
        AdmissionDate = DateTime.Now,
        Register = "0123456"        
      };      
    }
  }
}
