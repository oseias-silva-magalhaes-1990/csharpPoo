using System;

namespace ByteBank.Modelos.Funcionario
{
  public class Designer : Funcionario //Herança - herda atributos da classe base
  {
    public Designer(string cpf) : base (3000, cpf)//Atribuição de parâmetro para obedecer regra do construtor da classe base
    {
      Console.WriteLine("Criando um Designer");
    }
  
    internal protected override double GetBonificacao()//Definindo como override informa-se que o método é parte de uma classe pai
    {
      return Salario * 0.17;
    }
    
    public override void AumentarSalario()
    {
      Salario *= 1.11;
    }
  }
}
