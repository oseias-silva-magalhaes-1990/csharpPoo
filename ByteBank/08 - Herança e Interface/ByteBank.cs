using System;
using ByteBank.Funcionario;
using ByteBank.SistemA;

namespace ByteBank
{
  class Program
  {
    static void Main(string[] args)
    {
      //CalcularBonificacao();
      //UsarSistema();
      try
      {
      	ContaCorrente c1 = new ContaCorrente(0, 315253);
      }
      catch (ArgumentException ex)
      {
      	Console.WriteLine("Argumento com problema: " + ex.ParamName);
      }
      catch (Exception ex)
      {
      	Console.WriteLine(ex.Message);
      }
      
      //TestaDivisao(0);
      
      Console.ReadLine();
      
      Console.ReadLine();
      
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
  }
}
