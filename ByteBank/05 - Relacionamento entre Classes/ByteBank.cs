using System;

namespace _05_ByteBank
{
  class Program
  {
    static void Main (string[] args)
    {
        Cliente cliente1 = new Cliente();
        cliente1.nome = "Gabriela";
        cliente1.profissao = "Desenvolvedora C#";
        cliente1.cpf = "123.456.789-10";
      
        ContaCorrente conta1 = new ContaCorrente();
        conta1.titular = cliente1;//Atribui objeto da classe Cliente à objeto da classe ContaCorrente
        conta1.saldo = 563.0;
        conta1.agencia = 563;
        conta1.numero = 5634527;
        
        Console.WriteLine(cliente1.nome);//Imprime Valor Atribuido
        Console.WriteLine(conta1.titular.nome);//Imprime valor passado por referência
      
        Console.ReadLine();
    }
  }
}
