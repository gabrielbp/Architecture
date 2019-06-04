using System;
using System.Linq;

namespace Architecture.SOLID.OpenClosedPrinciple
{
  public abstract class AccountDebit
  {
    public string TransactionNumber { get; set; }
    public abstract string Debit(decimal value, string account);

    public string TransactionFormat()
    {
      const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
      var random = new Random();
      TransactionNumber = new string(Enumerable.Repeat(chars, 15)
        .Select(s => s[random.Next(s.Length)]).ToArray());

      return TransactionNumber;
    }    
  }
}
