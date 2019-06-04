using System.Net.Mail;

namespace Architecture.SOLID.SingleResponsabilityPrinciple
{
  public class EmailServices
  {
    public static bool IsValid(string email)
    {
      return email.Contains("@");
    }

    public static void Send(string emailFrom, string emailDestinantion, string emailSubject, string emailMessage)
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
