using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFundamentosPOO
{
    class Program
    {
        private const string NOME_DO_PROGRAMA = "Curso Linguagem C#";
        static void Main(string[] args)
        {
            //mensagem inicial do programa
            MostrarMensagemNaTela();

            Console.WriteLine("Informe qual tabuada? ");
            LerArquivos(1);
            Console.Read();
        }
        public static void LerArquivos(int numeroArquivo)
        {
            string pathUrlBase = $"C:\\Users\\Inaci\\Documents\\arquivosAulasTeste\\arq{numeroArquivo}.txt";
            if (File.Exists(pathUrlBase))
            {
                using (var arquivo = File.OpenText(pathUrlBase))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                    
                }
            }

            string pathUrlBaseProximo = $"C:\\Users\\Inaci\\Documents\\arquivosAulasTeste\\arq{numeroArquivo + 1}.txt";
            if (File.Exists(pathUrlBaseProximo))
                LerArquivos(numeroArquivo + 1);
        }
        public static void MostrarMensagemNaTela()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Programando na Linguagem C# .Net");
            Console.WriteLine("=================================");
        }
        
        public static int calcular()
        {
            var a = 1;
            var b = 2;
            return a + b;
        }
        public static void Tabuada(int numeroTab)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numeroTab} x {i} = {numeroTab * i}");
            }
        }
    }
}
