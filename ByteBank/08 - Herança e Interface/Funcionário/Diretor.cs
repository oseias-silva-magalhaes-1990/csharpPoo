using System;

namespace ByteBank
{
  public class Diretor : Funcionario //Herança - herda atributos da classe base
  {
    
    public Diretor(string cpf) : base (cpf)
    {
      Console.WriteLine("Criando um Diretor");
    }
  
    public override double GetBonificacao()//Definindo como override informa-se que o método é parte de uma classe pai
    {
      return Salario + base.GetBonificacao();
    }
    
  }
}
