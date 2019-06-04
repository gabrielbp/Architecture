using Architecture.SOLID.DependencyInversionPrinciple.Interfaces;

namespace Architecture.SOLID.DependencyInversionPrinciple
{
  public class CPFServices : ICPFServices
  {
    public bool IsValid(string cpf)
    {
      return cpf.Length == 11;
    }
  }
}
