using System;

namespace _01_ByteBank
{
  class Program
  {
    static void Main (string[] args)
    {
      ContaCorrente conta1 = new ContaCorrente();
      conta1.titular = "Joao";
      Console.WriteLine(conta1.titular);
    }
  }
}
