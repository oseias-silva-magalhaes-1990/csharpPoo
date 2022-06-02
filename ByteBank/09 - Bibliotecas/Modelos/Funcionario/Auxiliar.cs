using System;

namespace ByteBank.Modelos.Funcionario
{
  public class Auxiliar : Funcionario //Herança - herda atributos da classe base
  {
    public Auxiliar(string cpf) : base (2000, cpf)//Atribuição de parâmetro para obedecer regra do construtor da classe base
    {
      Console.WriteLine("Criando um Auxiliar");
    }
  
    public override double GetBonificacao()//Definindo como override informa-se que o método é parte de uma classe pai
    {
      return Salario * 0.2;
    }
    
    public override void AumentarSalario()
    {
      Salario *= 1.1;
    }
  }
}
