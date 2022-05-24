using System;
using ByteBank.Funcionario;

namespace ByteBank.Sistema
{
 public interface Autenticavel
  {
    bool Autenticar(string senha);
  }
}
