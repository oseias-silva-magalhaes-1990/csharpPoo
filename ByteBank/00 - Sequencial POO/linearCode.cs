using System;

namespace ByteBank
{
//CLIENTE*******************************    
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

//CONTA CORRENTE******************
  public class ContaCorrente
	{
		public static double TaxaOperacao{get; private set;}
		
		private static int TotalDeContasCriadas {get; set;}//Membro Estático - Característica da Classe
		//Método Get público e Set privado
		
        public Cliente Titular {get; set;}
                
		public int Agencia{get; set;}
		public int Numero{get; set;}
		
		public ContaCorrente(int agencia, int numero){
        
        	if(agencia <= 0)
            {
            	//Lançamento de exceção de argumento
            	throw new ArgumentException("O argumento agencia deve ser maior que Zero.");
            }
            
            if(numero <= 0)
            {
            	//Lançamento de exceção de argumento
            	throw new ArgumentException("O argumento numero deve ser maior que Zero.");
            }
            
			Agencia = agencia;
			Numero = numero;
            
            //TaxaOperacao = 30 / TotalDeContasCriadas;
			TotalDeContasCriadas++;
		}
		 
		private double _saldo = 100;
		public double Saldo
		{
			get
			{
				return this._saldo;
			}
			set
			{
				if(value < 0)
			{
				Console.WriteLine("Erro! Saldo negativo atribuído!");
				return;	
			}
				this._saldo = value; 
			}
		}

		  public bool Sacar(double valor){
			  
			if(this._saldo < valor){
				return false;
			}
			  
			this._saldo -= valor;
			return true;
		  }

		  public void Depositar(double valor){
		  	this._saldo += valor;
			Console.WriteLine("Depositou");
		  }

		  public bool Transferir(double valor, ContaCorrente contaDestino){
		  	if(this._saldo < valor){
		  		return false;
		  	}
			  
		  	this._saldo -= valor;
		  	contaDestino.Depositar(valor);
		  	return true;
		  }
	}
  
//INTERFACE AUTENTICAVEL******************
  public interface IAutenticavel
  {
    bool Autenticar(string senha);
  }
  
//SISTEMA INTERNO*************************  
  public class SistemaInterno
  {
    public bool Logar(IAutenticavel funcionario, string senha)
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

//GERENCIADOR BONIFICACAO*****************
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

//FUNCIONARIO AUTENTICAVEL****************
  public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
  {
    public string Senha {set; get;}
  
    public FuncionarioAutenticavel(double salario, string cpf): base (salario, cpf)
    {
      
    }
    
    public bool Autenticar(string senha)
    {
      return Senha == senha;
    }
    
  }

//FUNCIONARIO*******************************
  public abstract class Funcionario//Classe abstrata pois não deve ser instanciada
  {
    public static int TotalDeFuncionarios{get; private set;}
    
    public string Nome {get; set;}//public - visível em todo lugar;
    public string CPF {get; private set;}//private - apenas visível dentro da classe;
    public double Salario {get; protected set;}//protected - visível dentro da classe e também para as filhas;
    public string Senha {get; private set;}
    
    public Funcionario(double salario, string cpf)
    {
      CPF = cpf;
      Salario = salario;
      
      TotalDeFuncionarios++;
      Console.WriteLine("Criando um Funcionário");
    }
    
    public abstract double GetBonificacao();
    
    public abstract void AumentarSalario();
    
    /*
    public virtual double GetBonificacao()//Definindo como virtual o método pode ser utilziado por uma classe derivada e sofrer mudanças em sua estrutura
    {
      return Salario * 0.10;
    }
    
    public virtual void AumentarSalario()
    {
      Salario *= 1.1;
    }
    */
  }
  


//DIRETOR***********************************
  public class Diretor : FuncionarioAutenticavel //Herança - herda atributos da classe base
  {
    public Diretor(string cpf) : base (5000, cpf)//Atribuição de parâmetro para obedecer regra do construtor da classe base
    {
      Console.WriteLine("Criando um Diretor");
    }
  
    public override double GetBonificacao()//Definindo como override informa-se que o método é parte de uma classe pai
    {
      return Salario * 0.5;
    }
    
    public override void AumentarSalario()
    {
      Salario *= 1.15;
    }
  }
  
  //GERENTE DE CONTAS*********************
public class GerenteDeConta : FuncionarioAutenticavel//Herança - herda atributos da classe base
  {
    public GerenteDeConta(string cpf) : base (4000, cpf)//Atribuição de parâmetro para obedecer regra do construtor da classe base
    {
      Console.WriteLine("Criando um GerenteDeConta");
    }
  
    public override double GetBonificacao()//Definindo como override informa-se que o método é parte de uma classe pai
    {
      return Salario * 0.25;
    }
    
    public override void AumentarSalario()
    {
      Salario *= 1.05;
    }
    
  }

//DESIGNER**********************************
  public class Designer : Funcionario //Herança - herda atributos da classe base
  {
    
    public Designer(string cpf) : base (3000, cpf)//Atribuição de parâmetro para obedecer regra do construtor da classe base
    {
      Console.WriteLine("Criando um Designer");
    }
  
    public override double GetBonificacao()//Definindo como override informa-se que o método é parte de uma classe pai
    {
      return Salario * 0.17;
    }
    
    public override void AumentarSalario()
    {
      Salario *= 1.11;
    }
    
  }

//DESENVOLVEDOR*****************************
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

//AUXILAIR**********************************
  public class Auxiliar : Funcionario //Herança - herda atributos da classe base
  {
    
    public Auxiliar(string cpf) : base (2000, cpf)//Atribuição de parâmetro para obedecer regra do construtor da classe base
    {
      Console.WriteLine("Criando um Auxiliar");
    }
  
    public override double GetBonificacao()//Definindo como override informa-se que o método é parte de uma classe pai
    {
      return Salario * 0.2;
    }
    
    public override void AumentarSalario()
    {
      Salario *= 1.1;
    }
  }

//PARCEIRO COMERCIAL**************************
public class ParceiroComercial : IAutenticavel
  {
    public string Senha {get; set;}
    public bool Autenticar(string senha)
    {
      return Senha == senha;
    }
  }

//PROGRAMA*************************************
  class Program
  {
    public static void TestaDivisao(int divisor)
    {
    	try
        {
        	int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da Divisão:" + resultado);
        }
        catch(DivideByZeroException)
        {
        	Console.WriteLine("Não é possível dividir por zero!");
        }
    }
    
    public static int  Dividir(int numero, int divisor){
    	return numero/divisor;
    }
    
    public static void UsarSistema()
    {
      SistemaInterno sistemaInterno = new SistemaInterno();
      
      Diretor roberta = new Diretor("159.753.398-04");
      roberta.Nome = "Roberta";
      roberta.Senha = "123";
      
      sistemaInterno.Logar(roberta, "123");
      sistemaInterno.Logar(roberta, "abc");
      
      GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
      camila.Nome = "Camila";
      
      sistemaInterno.Logar(camila, "123");
      sistemaInterno.Logar(camila, "abc");
      
      ParceiroComercial parceiro = new ParceiroComercial();
      parceiro.Senha = "123456";
      
      sistemaInterno.Logar(parceiro, "123456");
      sistemaInterno.Logar(parceiro, "abc");
      
    }
    
    public static void CalcularBonificacao()
    {
      GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();
      
      Designer pedro = new Designer("833.222.048-39");
      pedro.Nome = "Pedro";
      
      Diretor roberta = new Diretor("159.753.398-04");
      roberta.Nome = "Roberta";
      
      Auxiliar igor = new Auxiliar("981.198.778-53");
      igor.Nome = "Igor";
      
      GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
      camila.Nome = "Camila";
      
      gerenciadorBonificacao.Registrar(pedro);
      gerenciadorBonificacao.Registrar(roberta);
      gerenciadorBonificacao.Registrar(igor);
      gerenciadorBonificacao.Registrar(camila);
      
      Console.WriteLine("Total de Bonificações do Mês:" + gerenciadorBonificacao.GetTotalBonificacao());
      
    }

//********************************MAIN**************************
    static void Main(string[] args)
    {
      //CalcularBonificacao();
      //UsarSistema();
      
      ContaCorrente c1 = new ContaCorrente(400, 315253);
      //c1.Titular.Nome = "Joao";
      
      ContaCorrente c2 = new ContaCorrente(0, 0);
      //c2.Titular.Nome = "Maria";

      //Console.WriteLine(ContaCorrente.TaxaOperacao);
      
      TestaDivisao(0);
      
      Console.ReadLine();
    }
  }
}
