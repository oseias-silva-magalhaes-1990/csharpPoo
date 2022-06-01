namespace ByteBank
{
        public class OperacaoFinanceiraException : Exception
        {
                public OperacaoFinanceiraException()
                {

                }

                public OperacaoFinanceiraException(string mensagem)
                    : base(mensagem)

                {

                }

                public OpracaoFinanceiraException(string mensagem, Exception excecaoInterna)
                    : base(mensagem, excecaoInterna)
                {

                }

        }
}
