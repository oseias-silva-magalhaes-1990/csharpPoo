using System;

namespace _06_ByteBank
{
  class Program
  {
    static void Main (string[] args)
    {
        ContaCorrente conta1 = new ContaCorrente();
        conta1.SetSaldo(-10);
        
        Console.WriteLine(conta1.GetSaldo());
        Console.ReadLine();
    }
  }
}