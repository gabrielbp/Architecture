namespace Architecture.SOLID.OpenClosedPrinciple.ExtensionMethods
{
  public static class SavingAccountDebit
  {
    public static string SavingDebit(this AccountDebit accountDebit)
    {
      //lógica de negócio

      return accountDebit.TransactionFormat();
    }
  }
}
