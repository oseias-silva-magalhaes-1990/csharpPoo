using System;

namespace ByteBank.Funcionario
{
    public class Estagiario : Funcionario
    {
        public Estagiario(double salario, string cpf)
        :base(salario, cpf)
        {
        
        }
        
        public override void AumentarSalario()
        {
        //Espaço para código
        }

        internal override double GetBonificacao()
        {
        //Espaço para código
        }
    }
}
