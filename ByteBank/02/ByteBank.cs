using System;

namespace _02_ByteBank
{
  class Program
  {
    static void Main (string[] args)
    {
      ContaCorrente conta = new ContaCorrente();
      conta.titular = "Gabriela";
      conta.agencia = 863;
      conta.numero = 863452;
      conta.saldo = 200.0;
      
      Console.WriteLine("Nome: " + conta.titular);
      Console.WriteLine("Agência: " + conta.agencia);
      Console.WriteLine("Conta: " + conta.numero);
      Console.WriteLine("Saldo: " + conta.saldo);
      
      Console.ReadLine();
    }
  }
}
