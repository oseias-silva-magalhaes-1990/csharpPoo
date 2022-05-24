using System;

namespace ByteBank
{
  public class ParceiroComercial : Autenticavel
  {
    public string Senha {get; set;}
    publicbool Autenticar(string senha)
    {
      return Senha == senha;
    }
  }
}
