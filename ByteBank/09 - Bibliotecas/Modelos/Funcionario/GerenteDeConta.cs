using System;

namespace ByteBank.Modelos.Funcionario
{
  public class GerenteDeConta : FuncionarioAutenticavel//Herança - herda atributos da classe base
  {
    public GerenteDeConta(string cpf) : base (4000, cpf)//Atribuição de parâmetro para obedecer regra do construtor da classe base
    {
      Console.WriteLine("Criando um GerenteDeConta");
    }
  
    internal override double GetBonificacao()//Definindo como override informa-se que o método é parte de uma classe pai
    {
      return Salario * 0.25;
    }
    
    public override void AumentarSalario()
    {
      Salario *= 1.05;
    }
  }
}
