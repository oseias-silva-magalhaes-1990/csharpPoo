using System;

namespace ByteBank.Modelos.Funcionario
{
  public abstract class Funcionario//Classe abstrata pois não deve ser instanciada
  {
    public static int TotalDeFuncionarios{get; private set;}
    
    public string Nome {get; set;}//public - visível em todo lugar;
    public string CPF {get; private set;}//private - apenas visível dentro da classe;
    public double Salario {get; protected set;}//protected - visível dentro da classe e também para as filhas;
    public string Senha {get; private set;}
    
    public Funcionario(double salario, string cpf)
    {
      CPF = cpf;
      Salario = salario;
      
      TotalDeFuncionarios++;
      Console.WriteLine("Criando um Funcionário");
    }
    
    internal abstract double GetBonificacao();
    
    public abstract void AumentarSalario();
      
    /*
    public virtual double GetBonificacao()//Definindo como virtual o método pode ser utilziado por uma classe derivada e sofrer mudanças em sua estrutura
    {
      return Salario * 0.10;
    }
    
    public virtual void AumentarSalario()
    {
      Salario *= 1.1;
    }
    */
    
  }
}
