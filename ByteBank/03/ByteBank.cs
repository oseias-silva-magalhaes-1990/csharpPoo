using System;

namespace _03_ByteBank
{
  class Program
  {
    static void Main (string[] args)
    {
      ContaCorrente conta = new ContaCorrente();
      conta.titular = "Gabriela";
      conta.agencia = 863;
      conta.numero = 863452;
      conta.saldo = 100.50;
      
      Console.WriteLine("Nome: " + conta.titular);
	  Console.WriteLine("Agência: " + conta.agencia);
      Console.WriteLine("Conta: " + conta.numero);
      Console.WriteLine("Saldo: " + conta.saldo);
      
      Console.ReadLine();
    }
  }
}
