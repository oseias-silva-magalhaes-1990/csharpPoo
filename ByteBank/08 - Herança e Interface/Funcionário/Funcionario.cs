using System;

namespace ByteBank.Funcionarios
{
  public class Funcionario
  {
    //0 - Operacional
    //1 - Diretor
    //2 - Designer
    //N - ...
    private int _tipo;
    
    public string Nome {get; set;}
    public string CPF {get; set;}
    public double Salario {get; set;}
    
    public Funcionario(int tipo){
      _tipo = tipo;
    }
    
    public double GetBonificacao()
    {
      return Salario * 0.10;
    }
  }
}
