using System;

namespace ByteBank
{
  public class Cliente
  {
    private string _cpf;
    
    public string Nome{get; set;}
    public string CPF{
      get
      {
        return this._cpf;
      }
      set
      {
        //Escrever validação de CPF
        this._cpf = value;
      }
    }
    
    public string Profissão{get; set;}
  }
}
