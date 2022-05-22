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
			
	    		conta1.depositar(100.0);
            		Console.WriteLine("Saldo: " + conta1.saldo);
            
            		conta1.sacar(50.0);
            		Console.WriteLine("Saldo: " + conta1.saldo);

			Console.ReadLine();
		}
  }
}
