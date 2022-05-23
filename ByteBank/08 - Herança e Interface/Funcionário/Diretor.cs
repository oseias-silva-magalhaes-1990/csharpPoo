using System;

namespace ByteBank.Funcionarios
{
  public class Diretor : Funcionario //Herança - herda atributos da classe base
  {
  
    public double GetBonificacao()
    {
      return Salario;
    }
    
  }
}
