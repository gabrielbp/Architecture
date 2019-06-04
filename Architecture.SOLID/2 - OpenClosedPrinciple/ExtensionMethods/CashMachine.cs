using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.SOLID.OpenClosedPrinciple.ExtensionMethods
{
  public class CashMachine
  {
    public static void Operation()
    {
      OperationMenu();

      var option = Console.ReadKey();
      var result = string.Empty;
      var accountDebit = DebitData();

      switch (option.KeyChar)
      {
        case '1':
          Console.WriteLine("Efetuando operação em Conta Corrente");
          result = accountDebit.CurrentDebit();
          break;

        case '2':
          Console.WriteLine("Efetuando operação em Conta Poupança");
          result = accountDebit.SavingDebit();
          break;

        case '3':
          Console.WriteLine("Efetuando operação em Conta de Investimento");
          result = accountDebit.InvestimentDebit();
          break;
      }

      TransactionReturn(result);
    }

    private static void OperationMenu()
    {
      Console.Clear();
      Console.WriteLine("Caixa Eletrônico");
      Console.WriteLine("Escolha a sua opção:");
      Console.WriteLine();
      Console.WriteLine("1 - Saque Conta Corrente");
      Console.WriteLine("2 - Saque Conta Poupança");
      Console.WriteLine("3 - Saque Conta Investimento");
    }

    private static AccountDebit DebitData()
    {
      Console.WriteLine();
      Console.WriteLine("........................");
      Console.WriteLine();
      Console.WriteLine("Digite a Conta");
      var account = Console.ReadLine();
      Console.WriteLine("Digite o Valor");
      var value = Convert.ToDecimal(Console.ReadLine());

      return new AccountDebit()
      {
        AccountNumber = account,
        Value = value
      };
    }

    private static void TransactionReturn(string result)
    {
      Console.WriteLine();
      Console.WriteLine($"Sucesso! Transação: {result}");
      Console.ReadKey();
    }
  }
}
