using System;

namespace ByteBank
{
  public class Funcionario
  {
    public static int TotalDeFuncionarios{get; private set;}
    
    public string Nome {get; set;}
    public string CPF {get; private set;}
    public double Salario {get; protected set;}
    
    public Funcionario(double salario, string cpf)
    {
      CPF = cpf;
      Salario = salario;
      
      TotalDeFuncionarios++;
      console.WriteLine("Criando um Funcionário");
    }
    
    public virtual double GetBonificacao()//Definindo como virtual o método pode ser utilziado por uma classe derivada e sofrer mudanças em sua estrutura
    {
      return Salario * 0.10;
    }
    
    public virtual void AumentarSalario()
    {
      Salario *= 1.1;
    }
  }
}
