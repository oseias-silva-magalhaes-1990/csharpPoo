using System;

namespace ByteBank.Funcionario
{
  public class GerenciadorBonificacao
  {
    private double _totalBonificacao; 
  
    public void Registrar(Funcionario func){
      _totalBonificacao += func.GetBonificacao();
    }
    
    public double GetTotalBonificacao(){
      return _totalBonificacao;
    }
    
  }
}
