using System;
using ByteBank.Funcionario;

namespace ByteBank.Sistema
{
 public abstract class Autenticavel: Funcionario
  {
    public string Senha {get; set;}
    
    public Autenticavel(double salario, string cpf) : base(salario, cpf)
    {
    }
    
    public bool Autenticar(string senha)
    {
      return Senha == senha;
    }
  }
}
