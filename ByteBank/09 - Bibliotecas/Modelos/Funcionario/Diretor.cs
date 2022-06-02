using System;
using ByteBank.Sistema;

namespace ByteBank.Modleos.Funcionario
{
  public class Diretor : FuncionarioAutenticavel //Herança - herda atributos da classe base
  {
    public Diretor(string cpf) : base (5000, cpf)//Atribuição de parâmetro para obedecer regra do construtor da classe base
    {
      Console.WriteLine("Criando um Diretor");
    }
  
    public override double GetBonificacao()//Definindo como override informa-se que o método é parte de uma classe pai
    {
      return Salario * 0.5;
    }
    
    public override void AumentarSalario()
    {
      Salario *= 1.15;
    }
    
  }
}
