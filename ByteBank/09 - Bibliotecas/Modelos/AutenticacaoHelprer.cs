using System;

namespace ByteBank.Modelos
{
  public class AutenticacaoHelper
  {
    public bool CompararSenha(string senhaVerdadeira, string senhaTentativa)
    {
      return senhaVerdadeira == senhaTentativa;
    }
  }
}
