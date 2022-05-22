using System;

namespace _04_ByteBank
{
  class Program
  {
    static void Main (string[] args)
		{
			ContaCorrente conta1 = new ContaCorrente();
			conta1.titular = "Gabriela";
			conta1.agencia = 863;
			conta1.numero = 863452;
			
	    		Console.WriteLine("Depositou? " + conta1.Depositar(100.0));
            		Console.WriteLine("Conta 1 - Saldo: " + conta1.saldo);
            
            		Console.WriteLine("Sacou? " + conta1.Sacar(50.0));
            		Console.WriteLine("Conta 1 - Saldo: " + conta1.saldo);
	    		
	    		ContaCorrente conta2 = new ContaCorrente();
	    		conta2.titular = "Bruno";
			conta2.agencia = 864;
			conta2.numero = 864324;
	    		
	    		conta1.Transferir(50.0, conta2);
	    		Console.WriteLine("Conta 2 - Saldo" + conta2.saldo);

			Console.ReadLine();
		}
  }
}
