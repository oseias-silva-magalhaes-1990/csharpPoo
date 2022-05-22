using System;

namespace _04_ByteBank
{
  class Program
  {
    static void Main (string[] args)
		{
			ContaCorrente conta = new ContaCorrente();
			conta.titular = "Gabriela";
			conta.agencia = 863;
			conta.numero = 863452;
			
	    		conta.depositar(100.0);
            		Console.WriteLine("Saldo: " + conta.saldo);
            
            		conta.sacar(50.0);
            		Console.WriteLine("Saldo: " + conta.saldo);

			Console.ReadLine();
		}
  }
}
