using System;

namespace ByteBank
{
  public class Desenvolvedor : Funcionario //Herança - herda atributos da classe base
  {
    
    public Desenvolvedor(string cpf) : base (5000, cpf)//Atribuição de parâmetro para obedecer regra do construtor da classe base
    {
      Console.WriteLine("Criando um Desenvolvedor");
    }
  
    public override double GetBonificacao()//Definindo como override informa-se que o método é parte de uma classe pai
    {
      return Salario * 0.1;
    }
    
    public override void AumentarSalario()
    {
      Salario *= 0.15;
    }
    
  }
}
