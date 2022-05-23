using system;

namespace ByteBank
{
  class Program
  {
    static void Main(string[] args)
    {
      GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
      
      Funcionario func = new Funcionario("379.721.748-25");//Atalho para coreção de Biblioteca (ctrl + . + enter)
      func.Nome = "Carlos";
      func.Salario = 2000;
      
      gerenciador.Registrar(func);
      
      //O objeto dire é originado a partir da classe Diretor() que é um polimorfismo da classe Funcionario()
      Diretor dire = new Diretor("374.731.747-36");//Atalho para coreção de Biblioteca (ctrl + . + enter)
      dire.Nome = "Roberta";
      dire.Salario = 5000;
      
      gerenciador.Registrar(dire);
      
      Console.WriteLine(func.Nome);
      Console.WriteLine(func.GetBonificacao());
      
      Console.WriteLine(dire.Nome);
      Console.WriteLine(dire.GetBonificacao());
      
      Console.WriteLine("Total de bonificações:" + gerenciador.GetBonificacao());
      
      Console.ReadLine();
      
    }
  }
}
