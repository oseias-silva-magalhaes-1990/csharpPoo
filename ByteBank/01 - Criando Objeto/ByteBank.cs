using System;

namespace _01_ByteBank
{
  class Program
  {
    static void Main (string[] args)
    {
      ContaCorrente conta1 = new ContaCorrente();
      conta1.titular = "Gabriela";
      conta1.agencia = 863;
      conta1.numero = 863452;
      conta1.saldo = 100.00;
      
      Console.WriteLine("Nome:" + conta1.titular);
      Console.WriteLine("Agência:" + conta1.agencia);
      Console.WriteLine("Conta:" + conta1.numero);
      Console.WriteLine("Saldo:" + conta1.saldo);
      
      Console.ReadLine();
    }
  }
}
