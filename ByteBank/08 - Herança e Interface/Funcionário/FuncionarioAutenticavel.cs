using System;

namespace Bytebank.Funcionarios
{
  public abstract class FuncionarioAutenticavel : Funcionario, Autenticavel
  {
    public string Senha {set; get;}
  
    public FuncionarioAutenticavel(double salario, string cpf): base (salario, cpf)
    {
      
    }
    
    public bool Autenticar(string senha)
    {
      return Senha == senha;
    }
    
  }
}
