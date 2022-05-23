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
    
    public void Registrar(Diretor dire){
      _totalBonificacao += dire.GetBonificacao();
    }
    
    public double GetTotalBonificacao(){
      return _totalBonificacao;
    }
    
  }
}
