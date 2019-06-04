namespace Architecture.SOLID.SingleResponsabilityPrinciple
{
  public class CPFServices
  {
    public static bool IsValid(string cpf)
    {
      return cpf.Length == 11;
    }
  }
}
