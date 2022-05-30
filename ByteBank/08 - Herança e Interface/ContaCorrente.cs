using System;

namespace _07_ByteBank
{
	public class ContaCorrente
	{
		public static double TaxaOperacao{get; private set;}
		
		private static int TotalDeContasCriadas {get; private set;}//Membro Estático - Característica da Classe
		//Método Get público e Set privado
		
                public Cliente Titular {get; set;}
                
		public int Numero {get;}//Campo somente de leitura
                public int Agencia {get;}//Campo somente de leitura
		
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
			//Agencia e Numero somente de leitura
			Agencia = agencia; //Valor atribuido apenas no momento da criaçã odo objeto
			Numero = numero;   //Valor atribuido apenas no momento da criaçã odo objeto
                        
                        TaxaOperacao = 30 / TotalDeContasCriadas;
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
}
