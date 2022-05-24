using System;

namespace ByteBank
{
  public class Diretor : Funcionario //Herança - herda atributos da classe base
  {
    
    public Diretor(double salario, string cpf) : base (salario, cpf)//Atribuição de parâmetro para obedecer regra do construtor da classe base
    {
      Console.WriteLine("Criando um Diretor");
    }
  
    public override double GetBonificacao()//Definindo como override informa-se que o método é parte de uma classe pai
    {
      return Salario + base.GetBonificacao();
    }
    
    public override void AumentarSalario()
    {
      Salario *= 1.15;
    }
    
  }
}
