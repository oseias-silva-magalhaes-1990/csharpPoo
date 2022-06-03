using System;

namespace ByteBank.Modelos
{
  internal class AutenticacaoHelper
  {
    public bool CompararSenha(string senhaVerdadeira, string senhaTentativa)
    {
      return senhaVerdadeira == senhaTentativa;
    }
  }
}
