using System;

namespace _06_ByteBank
{
  class Program
  {
    static void Main (string[] args)
    {
        ContaCorrente conta1 = new ContaCorrente();
        conta1.Saldo = -10;
        
        Console.WriteLine(conta1.Saldo);
        Console.ReadLine();
    }
  }
}
