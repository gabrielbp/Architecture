namespace Architecture.SOLID.DependencyInversionPrinciple.Interfaces
{
  public interface IEmailServices
  {
    bool IsValid(string email);
    void Send(string emailFrom, string emailDestinantion, string emailSubject, string emailMessage);
  }
}
