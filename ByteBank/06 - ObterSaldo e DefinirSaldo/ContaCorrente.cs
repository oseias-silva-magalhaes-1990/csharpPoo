using System;

namespace _06_ByteBank
{
	public class ContaCorrente
	{
		  public Cliente titular;
		  public int agencia;
		  public int numero;
		  public double saldo = 100;

		  public bool Sacar(double valor){
			if(this.saldo < valor){
				return false;
			}
			  
			this.saldo -= valor;
			return true;
		  }

		  public void Depositar(double valor){
		  	this.saldo += valor;
			Console.WriteLine("Depositou");
		  }

		  public bool Transferir(double valor, ContaCorrente contaDestino){
		  	if(this.saldo < valor){
		  		return false;
		  	}
			  
		  	this.saldo -= valor;
		  	contaDestino.Depositar(valor);
		  	return true;
		  }
	}
}
