using System;
using ByteBank.Funcionarios

namespace ByteBank
{
  public class GerenciadorBonificacao
  {
    private double _totalBonificacao; 
  
    public void Registrar(Funcionario func){
      _totalBonificacao += func.GetBonificacao();
    }
    
    public double TotalBonificacao(){
      return _totalBonificacao;
    }
    
  }
}
