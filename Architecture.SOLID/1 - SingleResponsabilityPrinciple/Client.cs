using System;

namespace Architecture.SOLID.SingleResponsabilityPrinciple
{
  public class Client
  {
    public int ClientId { get; private set; }
    public string Name { get; private set; }
    public string Email { get; private set; }
    public string CPF { get; private set; }
    public DateTime RegisterDate { get; private set; }

    public bool IsValid()
    {
      return EmailServices.IsValid(Email) && CPFServices.IsValid(CPF);
    }
  }
}
