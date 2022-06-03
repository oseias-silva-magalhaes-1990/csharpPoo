using System;

namespace ByteBank.Modelos
{
  public class GerenciadorBonificacao
  {
    private double _totalBonificacao; 
  
    public void Registrar(Funcionario func){
      _totalBonificacao += func.GetBonificacao();
    }
    
    internal double GetTotalBonificacao(){
      return _totalBonificacao;
    }
    
  }
}
