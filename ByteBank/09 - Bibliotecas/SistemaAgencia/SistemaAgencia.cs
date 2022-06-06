using System;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.Sistema;

namespace ByteBank.SistemaAgencia
{
  class Program
  {
    static void Main(string[] args)
    {
      //Em Referências deve-se adicionar a referência ByteBank.Modelos dentro de Projetos
      ContaCorrente conta = new ContaCorrente(847, 489754);
      
      AutenticacaoHelper
      
      Funcionario funcionario = null;
      Console.WriteLine(conta.Numero);
      
      Console.ReadLine();
    }
  }
}
