using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFundamentosPOO.Modelos
{
    public class Menu
    {
        private const string NOME_DO_PROGRAMA = "Curso Linguagem C#";
        private const int SAIDA_PROGRAMA = 0;
        private const int LER_ARQUIVOS = 1;
        private const int TABUADA = 2;
        private const int CALCULO_MEDIA = 3;
        public static void MenuDeOpcoes()
        {
            string mensagem = "Olá usuário, bem vindo ao program, utilizando programação funcional" +
                "\nDigite uma das opções abaixo:" +
                "\n0 - sair" +
                "\n1 - Ler Arquivos" +
                "\n2 - Tabuada" +
                "\n3 - Calcular";
            while (true)
            {
                Console.WriteLine("=====================================");
                Console.WriteLine(mensagem);
                Console.WriteLine("=====================================");
                int valor = int.Parse(Console.ReadLine());

                if (SAIDA_PROGRAMA == valor)
                {
                    break;
                }
                else if (LER_ARQUIVOS == valor)
                {
                    Arquivos.LerArquivos(1);
                }
                else if (TABUADA == valor)
                {
                    Console.WriteLine("qual tabuada deseja ser exibida ?");
                    int tab = int.Parse(Console.ReadLine());
                    Tabuada.GerarTabuada(tab);
                }
                else if (CALCULO_MEDIA == valor)
                {
                    CalculoMedia.CalcularMediaAluno();
                }
                else
                {
                    Console.WriteLine("Opções, a opção digitada não existe!");
                }
            }
        }
    }
}
