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
			
	    		Console.WriteLine("Depositou? " + conta1.depositar(100.0));
            		Console.WriteLine("Saldo: " + conta1.saldo);
            
            		Console.WriteLine("Sacou? " + conta1.sacar(50.0));
            		Console.WriteLine("Saldo: " + conta1.saldo);

			Console.ReadLine();
		}
  }
}
