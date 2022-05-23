using System;

namespace _07_ByteBank
{
  class Program
  {
    static void Main (string[] args)
    {
        ContaCorrente conta = new ContaCorrente(867, 315253);
      
        Console.WriteLine(conta.Agencia);
        Console.WriteLine(conta.Numero);

    }
  }
}
