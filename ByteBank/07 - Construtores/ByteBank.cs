using System;

namespace _07_ByteBank
{
  class Program
  {
    static void Main (string[] args)
    {
        ContaCorrente conta = new ContaCorrente();
        Cliente cliente = new Cliente();
          
        cliente.Nome = "Guilherme";
        cliente.CPF = "123.456.789-10";
        cliente.Profissao = "Desenvolvedor";
        
        conta.Saldo = -10;
        
        Console.WriteLine(conta.Saldo);
        Console.WriteLine(conta.Titular.Nome);
        Console.ReadLine();
    }
  }
}
