using system;
using ByteBank.Funcionarios;

namespace ByteBank
{
  class Program
  {
    static void Main(string[] args)
    {
      Funcionario func = new Funcionario();//Atalho para coreção de Biblioteca (ctrl + . + enter)
      func.Nome = "Carlos";
      func.CPF = "379.721.748-25";
      func.Salario = 2000;
      
      Diretor diret = new Diretor();//Atalho para coreção de Biblioteca (ctrl + . + enter)
      diret.Nome = "Roberta";
      diret.CPF = "374.731.747-36";
      diret.Salario = 5000;
      
      Console.WriteLine(func.Nome);
      Console.WriteLine(func.GetBonificacao());
      
      Console.WriteLine(diret.Nome);
      Console.WriteLine(diret.GetBonificacao());
      
      Console.ReadLine();
      
    }
  }
}
