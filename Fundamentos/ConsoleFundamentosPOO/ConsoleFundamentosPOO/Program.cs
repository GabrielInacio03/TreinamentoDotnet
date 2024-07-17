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
        private const int SAIDA_PROGRAMA = 0;
        private const int LER_ARQUIVOS = 1;
        private const int TABUADA = 2;
        private const int CALCULO_MEDIA = 3;
        static void Main(string[] args)
        {
            MenuDeOpcoes();
            Console.Read();
        }
        public static void MenuDeOpcoes()
        {
            string mensagem = "Olá usuário, bem vindo ao program, utilizando programação funcional"+
                "\nDigite uma das opções abaixo:"+
                "\n0 - sair"+
                "\n1 - Ler Arquivos"+
                "\n2 - Tabuada"+
                "\n3 - Calcular";
            while (true)
            {
                Console.WriteLine("=====================================");
                Console.WriteLine(mensagem);                
                Console.WriteLine("=====================================");
                int valor = int.Parse(Console.ReadLine());
                
                if(SAIDA_PROGRAMA == valor)
                {
                    break;
                }else if(LER_ARQUIVOS == valor)
                {
                    LerArquivos(1);
                }else if(TABUADA == valor)
                {
                    Console.WriteLine("qual tabuada deseja ser exibida ?");
                    int tab = int.Parse(Console.ReadLine());
                    Tabuada(tab);
                }else if(CALCULO_MEDIA == valor)
                {
                    CalcularMediaAluno();
                }
                else
                {
                    Console.WriteLine("Opções, a opção digitada não existe!");
                }
            }            
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
        public static void CalcularMediaAluno()
        {
            int qtdNotas = 3;
            string nomeAluno = string.Empty;

            Console.WriteLine("Digite o nome do aluno");
            nomeAluno = Console.ReadLine();

            Console.WriteLine($"Digite as {qtdNotas} notas do aluno");           
            
            List<int> notas = new List<int>();
            int somaTotalNotas = 0;
            for (int i = 1; i <= qtdNotas; i++)
            {
                Console.WriteLine($"digite a nota número {i}");
                int nota = int.Parse(Console.ReadLine());
                notas.Add(nota);
                somaTotalNotas += nota;
            }

            var media = somaTotalNotas / qtdNotas;            
            Console.WriteLine($"A média do aluno {nomeAluno} é: {media}");
        }
    }
}
