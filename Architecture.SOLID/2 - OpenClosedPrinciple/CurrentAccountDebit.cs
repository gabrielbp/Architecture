namespace Architecture.SOLID.OpenClosedPrinciple
{
  public class CurrentAccountDebit : AccountDebit
  {
    public override string Debit(decimal value, string account)
    {     
      return TransactionFormat();
    }
  }
}
