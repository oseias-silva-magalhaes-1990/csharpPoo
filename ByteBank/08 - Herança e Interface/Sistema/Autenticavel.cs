using System;
using ByteBank.Funcionario;

namespace ByteBank.Sistema
{
 public class SistemaInterno
  {
    public string Senha {get; set;}
    
    public bool Autentica(string senha)
    {
      return Senha == senha;
    }
  }
}
