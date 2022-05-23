using System;

namespace ByteBank
{
  public class Funcionario
  {
    public string Nome {get; set;}
    public string CPF {get; set;}
    public double Salario {get; set;}
    
    public virtual double GetBonificacao()//Definindo como virtual o método pode ser utilziado por uma classe derivada e sofrer mudanças em sua estrutura
    {
      return Salario * 0.10;
    }
  }
}
