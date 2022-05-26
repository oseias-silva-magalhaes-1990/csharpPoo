namespace ByteBank
{
        public class ContaCorrente
        {
                public static double TaxaOperacao { get; private set; }
                
                public Cliente Titular {get; set:}
                
                public int Numero {get; set;}
                
                private int _agencia;
                
                public int Agencia 
                {
                  get
                  {
                    return _agencia;
                  }
                  set
                  {
                    _agencia = value;
                  }
                }

                public static int TotalDeContasCriadas { get; private set; }

}
