using System;

namespace _07_ByteBank
{
	public class ContaCorrente
	{
		public Cliente Titular {get; set;}
		
		public static int TotalDeContasCriadas {get; set;}//Membro Estático
		
		public int Agencia{get; set;}
		public int Numero{get; set;}
		
		public ContaCorrente(int agencia, int numero){
			Agencia = agencia;
			Numero = numero;
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
