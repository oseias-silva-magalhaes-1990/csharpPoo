using system;
using ByteBank.Funcionarios;

namespace ByteBank
{
  clas Program
  {
    static void Main(string[] args)
    {
      Funcionario func = new Funcionario();//Atalho para coreção de Biblioteca (ctrl + . + enter)
      func.Nome = "Carlos";
      func.CPF = "379.721.748-25";
      func.Salario = 2000;
      
      Console.WriteLine(func.GetBonificacao());
      
      Console.ReadLine();
      
    }
  }
}
