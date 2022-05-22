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
			conta1.saldo = 100.50;			

			Console.ReadLine();
		}
  }
}
