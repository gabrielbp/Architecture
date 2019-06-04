namespace Architecture.SOLID.OpenClosedPrinciple.ExtensionMethods
{
  public static class CurrentAccountDebit
  {
    public static string CurrentDebit(this AccountDebit accountDebit)
    {
      //lógica de negócio

      return accountDebit.TransactionFormat();
    }
  }
}
