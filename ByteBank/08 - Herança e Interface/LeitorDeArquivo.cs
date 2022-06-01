using System;

namespace ByteBank
{
    public class LeitorDeArquivo : IDisposable
    {
        public string Arquivo { get; }

        public LeitorDeArquivo(string arquivo)
        {
                Arquivo = arquivo;
                Console.WriteLine("Abrindo arquivo: " + arquivo);
        }

        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo linha...");

            throw new IOException();

            return "linha do arquivo";
        }

        public void Fechar()
        {
                Console.WriteLine("Fechando arquivo.");
        }
        
        public void Dispose()
        {
        
        }
    }
}
