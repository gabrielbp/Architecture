﻿using System;
using System.Linq;

namespace Architecture.SOLID.OpenClosedPrinciple.ExtensionMethods
{
  public class AccountDebit
  {
    public string AccountNumber { get; set; }
    public decimal Value { get; set; }
    public string TransactionNumber { get; set; }    

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
