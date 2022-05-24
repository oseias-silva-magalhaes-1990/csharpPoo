using System;
using ByteBank.Funcionario;

namespace ByteBank.Sistema
{
 public class SistemaInterno
  {
    public bool Logar(Diretor funcionario, string senha)
    {
      bool usuarioAutenticado = funcionario.Autenticar(senha);
      
      if (usuarioAutenticado){
        Console.WriteLine("Bem vindo ao Sistema!");
        return true;
      }
      else
      {
        Console.WriteLine("Login/Senha Incorreta!");
        return false;
      }
    }
    
    public bool Logar(GerenteDeConta funcionario, string senha)
    {
      bool usuarioAutenticado = funcionario.Autenticar(senha);
      
      if (usuarioAutenticado){
        Console.WriteLine("Bem vindo ao Sistema!");
        return true;
      }
      else
      {
        Console.WriteLine("Login/Senha Incorreta!");
        return false;
      }
    }
    
  }
}
