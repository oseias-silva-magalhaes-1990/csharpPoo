using System;

namespace ByteBank.Modelos
{
	/// <summary>
	/// Define uma Conta Corrente do banco ByteBank.
	/// </summary>
	public class ContaCorrente
	{
		public static double TaxaOperacao{get; private set;}
		
		private static int TotalDeContasCriadas {get; private set;}//Membro Estático - Característica da Classe
		//Método Get público e Set privado
		
                public Cliente Titular {get; set;}
		
		public int ContadorSaquesNaoPermitidos { get; private set; }
        	public int ContadorTransferenciasNaoPermitidas { get; private set; }
                
		public int Numero {get;}//Campo somente de leitura
                public int Agencia {get;}//Campo somente de leitura
		
		/// <summary>
		/// Cria uma instancia de coonta Corrente com os argumentos utilizados.
		/// </summary>
		/// <param name="agencia">Representa o valor da propriedade <see cref="Agencia"/> e deve possuir o valor maior que zero.</param>
		/// <param name="numero">Representa o valor da propriedade <see cref="Numero"/> e deve possuir o valor maior que zero.</param>
		public ContaCorrente(int agencia, int numero){
			if(agencia <= 0)
			{
				//Lançamento de exceção de argumento
				throw new ArgumentException("O argumento agencia deve ser maior que Zero.", nameof(agencia));
			}
			
			if(numero <= 0)
			{
				//Lançamento de exceção de argumento
			}
            
			Agencia = agencia;
			Numero = numero;
            
			TotalDeContasCriadas++;
			TaxaOperacao = 30 / TotalDeContasCriadas;
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
			
			if(valor < 0)
			{
				throw new ArgumentException("Valor inválido para saque.", nameof(valor));
			}
			
			if(this._saldo < valor)
			{
				throw new SaldoInsuficienteException(Saldo, valor);
			}
			  
			this._saldo -= valor;
			return true;
		}
		
		public void Depositar(double valor)
		{
			this._saldo += valor;
			Console.WriteLine("Depositou");
		}
		
		public void Transferir(double valor, ContaCorrente contaDestino)
		{
			if(valor < 0)
			{
				throw new ArgumentException("Valor inválido para transferência.", nameof(valor));
			}
			try
			{
				Sacar(valor);
			}
			catch(SaldoInsuficienteException ex)
			{
				ContadorTransferenciasNaoPermitidas++;
				throw new SaldoInsuficienteException("Operação não realizada.", ex);
			}
		  	contaDestino.Depositar(valor);
		}
	}
}
