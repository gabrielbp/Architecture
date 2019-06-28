namespace Architecture.SOLID.OpenClosedPrinciple
{
  public class InvestimentAccountDebit : AccountDebit
  {
    public override string Debit(decimal value, string account)
    {
      return TransactionFormat();
            //teste gabriel
    }
  }
}
