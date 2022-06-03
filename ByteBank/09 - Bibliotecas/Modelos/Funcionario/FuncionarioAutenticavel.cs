using System;

namespace Bytebank.Modelos.Funcionarios
{
  public abstract class FuncionarioAutenticavel : Funcionario, Autenticavel
  {
    private AutenticacaoHelper _autenticacaoHelper = new AutenticacaoHelper();
    public string Senha {set; get;}
  
    public FuncionarioAutenticavel(double salario, string cpf): base (salario, cpf)
    {
      
    }
    
    public bool Autenticar(string senha)
    {
      return _autenticacaoHelper.CompararSenha(Senha, senha);
    }
    
  }
}
