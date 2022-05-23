using System;

namespace ByteBank
{
  public class Funcionario
  {
    public static int TotalDeFuncionarios{get; private set;}
    
    public string Nome {get; set;}
    public string CPF {get; private set;}
    public double Salario {get; set;}
    
    public Funcionario(string cpf)
    {
      CPF = cpf;
      TotalDeFuncionarios++;
    }
    
    public virtual double GetBonificacao()//Definindo como virtual o método pode ser utilziado por uma classe derivada e sofrer mudanças em sua estrutura
    {
      return Salario * 0.10;
    }
  }
}
