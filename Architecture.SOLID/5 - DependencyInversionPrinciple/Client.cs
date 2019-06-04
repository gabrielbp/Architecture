using Architecture.SOLID.DependencyInversionPrinciple.Interfaces;
using System;

namespace Architecture.SOLID.DependencyInversionPrinciple
{
  public class Client
  {
    private readonly IEmailServices _emailServices;
    private readonly ICPFServices _cpfServices;

    public Client(IEmailServices emailServices, ICPFServices cpfServices)
    {
      _emailServices = emailServices;
      _cpfServices = cpfServices;
    }

    public int ClientId { get; private set; }
    public string Name { get; private set; }
    public string Email { get; private set; }
    public string CPF { get; private set; }
    public DateTime RegisterDate { get; private set; }

    public bool IsValid()
    {
      return _emailServices.IsValid(Email) && _cpfServices.IsValid(CPF);
    }
  }
}
