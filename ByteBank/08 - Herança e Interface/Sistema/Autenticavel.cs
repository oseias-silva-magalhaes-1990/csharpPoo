using System;
using ByteBank.Funcionario;

namespace ByteBank.Sistema
{
 public interface IAutenticavel
  {
    bool Autenticar(string senha);
  }
}
