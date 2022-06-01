using System;
using ByteBank.Funcionario;
using ByteBank.Sistema;
using LeitorDeArquivo;

namespace ByteBank
{
  class Program
  {
    static void Main(string[] args)
    {
      try
      {
          CarregarContas();
      }
      catch(Exception)
      {
          Console.WriteLine("CATCH NO METODO MAIN");
      }
    }
    
    private static void CarregarContas()
    {
        using (LeitorDeArquivo leitor = new LeitorDeArquivo("teste.txt"))
        {
                leitor.LerProximaLinha();
        }
      
      /*
        LeitorDeArquivo leitor = null;
      //-----------------------------------------------------------------------------
        try 
        {
              leitor = new LeitorDeArquivo("contas.txt");

              leitor.LerProximaLinha();
              leitor.LerProximaLinha();
              leitor.LerProximaLinha();

        }
        catch(IOException)
        {
              Console.WriteLine("Exceção do tipo IOException capturada e tratada!");
        }
        finally
        {
              if(leitor != null
               {

                 leitor.Fechar();
               } 
        }
        */
    }
    
    public static void UsarSistema()
    {
      SistemaInterno sistemaInterno = new SistemaInterno();
      
      Diretor roberta = new Diretor("159.753.398-04");
      roberta.Nome = "Roberta";
      roberta.Senha = "123";
      
      sistemaInterno.Logar(roberta, "123");
      sistemaInterno.Logar(roberta, "abc");
      
      GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
      camila.Nome = "Camila";
      
      sistemaInterno.Logar(camila, "123");
      sistemaInterno.Logar(camila, "abc");
      
      ParceiroComercial parceiro = new ParceiroComercial();
      parceiro.Senha = "123456";
      
      sistemaInterno.Logar(parceiro, "123456");
      sistemaInterno.Logar(parceiro, "abc");
      
    }
    
    public static void CalcularBonificacao()
    {
      GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();
      
      Designer pedro = new Designer("833.222.048-39");
      pedro.Nome = "Pedro";
      
      Diretor roberta = new Diretor("159.753.398-04");
      roberta.Nome = "Roberta";
      
      Auxiliar igor = new Auxiliar("981.198.778-53");
      igor.Nome = "Igor";
      
      GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
      camila.Nome = "Camila";
      
      gerenciadorBonificacao.Registrar(pedro);
      gerenciadorBonificacao.Registrar(roberta);
      gerenciadorBonificacao.Registrar(igor);
      gerenciadorBonificacao.Registrar(camila);
      
      Console.WriteLine("Total de Bonificações do Mês:" + gerenciadorBonificacao.GetTotalBonificacao());
      
    }
    
    private static void TestaInnerException()
    {
      try
      {
      	ContaCorrente conta1 = new ContaCorrente(4564, 789684);
        ContaCorrente conta2 = new ContaCorrenet(7891, 456794);
        
        // conta1.Transferir(10000, conta2);
         conta1.Sacar(10000);
      }
      catch (ArgumentException ex)
      {
      	Console.WriteLine("Argumento com problema: " + ex.ParamName);
      }
      catch (SaldoInsuficienteException ex)
      {
        Console.WriteLine(ex.Message);
        Console.WriteLine("Exceção do tipo Saldo Insuficiente Exceptioon");
      }
      catch (Exception e)
      {
      	Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                Console.WriteLine("Informações da INNER EXCEPTION (exceção interna):");

                Console.WriteLine(e.InnerException.Message);
                Console.WriteLine(e.InnerException.StackTrace);
      }
      
      //TestaDivisao(0);
      
      Console.ReadLine();
    }
  }
}
