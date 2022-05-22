using System;

namespace _03_ByteBank
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

			ContaCorrente conta2 = new ContaCorrente();
			conta2.titular = "Gabriela";
			conta2.agencia = 863;
			conta2.numero = 863452;
			conta2.saldo = 100.50;

			Console.WriteLine("Igualdade de tipo de referência: " + (conta1 == conta2));

			int idade1 = 27;
			int idade2 = 27;
			
			Console.WriteLine("Igualdade de tipo de Valor: " + (idade1 == idade2));
			
			conta1 = conta2;//Atribuição de objetos - referência de posição na memória computacional alterada
			Console.WriteLine("Igualdade de tipo de referência: " + (conta1 == conta2));
			
			Console.ReadLine();
		}
	}
}
