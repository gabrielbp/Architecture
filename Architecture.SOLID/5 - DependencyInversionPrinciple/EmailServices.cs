using Architecture.SOLID.DependencyInversionPrinciple.Interfaces;
using System.Net.Mail;

namespace Architecture.SOLID.DependencyInversionPrinciple
{
  public class EmailServices : IEmailServices
  {
    public bool IsValid(string email)
    {
      return email.Contains("@");
    }

    public void Send(string emailFrom, string emailDestinantion, string emailSubject, string emailMessage)
    {
      var mail = new MailMessage(emailFrom, emailDestinantion);
      mail.Subject = emailSubject;
      mail.Body = emailMessage;

      var client = new SmtpClient
      {
        Port = 25,
        DeliveryMethod = SmtpDeliveryMethod.Network,
        UseDefaultCredentials = false,
        Host = "smtp.google.com"
      };

      client.Send(mail);
    }
  }
}
