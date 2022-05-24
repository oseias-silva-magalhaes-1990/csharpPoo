using System;
using ByteBank.Funcionario;

namespace ByteBank.Sistema
{
 public class Autenticavel
  {
    public string Senha {get; set;}
    
    public bool Autenticar(string senha)
    {
      return Senha == senha;
    }
  }
}
