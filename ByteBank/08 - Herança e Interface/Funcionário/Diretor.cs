using System;

namespace ByteBank.Funcionarios
{
  public class Diretor : Funcionario //Herança - herda atributos da classe base
  {
  
    public override double GetBonificacao()//Definindo como override informa-se que o método é parte de uma classe pai
    {
      return Salario;
    }
    
  }
}
