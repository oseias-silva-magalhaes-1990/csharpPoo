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
      //Em Referências no Painel Lateral deve-se adicionar a referência ByteBank.Modelos dentro de Projetos
      ContaCorrente conta = new ContaCorrente(847, 489754);
      
      Funcionario funcionario = null;
      Console.WriteLine(conta.Numero);
      
      //Lidando com Datas
      DateTime dataFimPagamento = new DateTime(2018, 8, 17);
      DateTime dataCorrente = DateTime.Now;
      
      //TimeSpan diferenca = dataFimPagamento - dataCorrente;//TimeSpan recebe a diferença entre datas.
      
      TimeSpan diferenca = TimeSpan.FromMinutes(60);//Devolve o valor do parâmetro convertido em minutos 
      
      //https://www.nuget.org/packages/Humanizer/
      string mensagem = "Vencimento em: " + TimeSpanHumanizeExtensions.Humanize(diferenca); //Humanize é uma biblioteca .dll especializada para a humanizaçã ode escrita de resultados no console.
      
      Console.WriteLine(mensagem);
      
      Console.ReadLine();
    }

  }
}
