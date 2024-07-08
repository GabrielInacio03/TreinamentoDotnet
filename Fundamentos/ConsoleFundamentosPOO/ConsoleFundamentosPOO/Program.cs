using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFundamentosPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = 1;

            //ternario
            bool verdadeiro = (a == 1) ? true : false;
            //condicional if else if e else

            //if (a == 1) Console.WriteLine("entrou na condição if");
            if (a == 1)
            {
                Console.WriteLine("entrou na condição do if");
                Console.WriteLine("========");
            }
            else if(a == 2)
            {
                Console.WriteLine("entrou na condição do else if");
                Console.WriteLine("========");
            }
            else
            {
                Console.WriteLine("entrou na condição senão, else.");
                Console.WriteLine("========");
            }

            //condicional switch
            var opcao = 0;
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("opcao 1");
                    break;
                case 2:
                    Console.WriteLine("opcao 2");
                    break;
                case 3:
                    Console.WriteLine("opcao 3");
                    break;
                default:
                    Console.WriteLine("opção 0");
                    break;
            }

            Console.WriteLine("Olá pessoal");
            Console.Read();
        }
    }
}
