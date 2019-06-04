namespace Architecture.SOLID.OpenClosedPrinciple
{
  class SavingAccountDebit : AccountDebit
  {
    public override string Debit(decimal value, string account)
    {
      return TransactionFormat();
    }
  }
}
