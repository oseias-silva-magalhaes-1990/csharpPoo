

using System;

namespace ByteBank
{
  class SaldoInsuficienteException : Exception
  {
    public SaldoInsuficienteException()
    {
    
    }
    public SaldoInsuficienteException(string mensagem) : base(mensagem)
    {
    
    }
  }
}
