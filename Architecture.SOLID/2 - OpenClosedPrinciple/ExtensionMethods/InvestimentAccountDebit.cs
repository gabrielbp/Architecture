namespace Architecture.SOLID.OpenClosedPrinciple.ExtensionMethods
{
  public static class InvestimentAccountDebit
  {
    public static string InvestimentDebit(this AccountDebit accountDebit)
    {
      //lógica de negócio

      return accountDebit.TransactionFormat();
    }
  }
}
