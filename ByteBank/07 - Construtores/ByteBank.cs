using System;

namespace _07_ByteBank
{
  class Program
  {
    static void Main (string[] args)
    {
        ContaCorrente conta1 = new ContaCorrente(867, 315253);
        Console.WriteLine(conta1.Agencia);
        Console.WriteLine(conta1.Numero);
      
        ContaCorrente conta2 = new ContaCorrente(863, 315254);
      
        Console.WriteLine(conta2.Agencia);
        Console.WriteLine(conta2.Numero);
      
        Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

    }
  }
}
