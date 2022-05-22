using System;

namespace _04_ByteBank
{
  class Program
  {
    static void Main (string[] args)
    {
	bool transferiu;
        bool sacou;
	    
	ContaCorrente conta1 = new ContaCorrente();//Conta 1
	conta1.titular = "Gabriela";
	conta1.agencia = 863;
	conta1.numero = 863452;
			
        Console.WriteLine("Conta 1 | Saldo: " + conta1.saldo);
        conta1.Depositar(100.0);
	Console.WriteLine("Depositou ");
        Console.WriteLine("Conta 1 | Saldo: " + conta1.saldo);
            
        sacou = conta1.Sacar(50.0);
        Console.WriteLine("Sacou? " + sacou);
        Console.WriteLine("Conta 1 | Saldo: " + conta1.saldo);
	    		
	ContaCorrente conta2 = new ContaCorrente();//Conta 2
	conta2.titular = "Bruno";
	conta2.agencia = 864;
	conta2.numero = 864324;
	Console.WriteLine("Conta 2 | Saldo: " + conta2.saldo);
            
	transferiu = conta1.Transferir(50.0, conta2);
	Console.WriteLine("Transferiu?: " + transferiu); //Transferência de valor Obj 1 para Obj 2
	Console.WriteLine("Conta 2 | Saldo: " + conta2.saldo);

	Console.ReadLine();
    }
  }
}
