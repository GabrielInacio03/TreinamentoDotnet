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

            var a = 0;

            //while
            while(a <= 5)
            {
                Console.WriteLine($"a: {a}");
                a++;
            }

            //do while
            //primeiro ele faz a operação e depois verifica os valores
            do
            {
                Console.WriteLine(a);
                a++;
            } while (a <= 5);

            //for
            int x = 10;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(x);
            }

            //foreach
            char[] alfabeto = {'A', 'B', 'C', 'D', 'E' };
            foreach (var letra in alfabeto)
            {
                Console.WriteLine($"Letra: {letra}");
            }
            Console.WriteLine("Olá pessoal");
            Console.Read();
        }
        public int loopRecursiva(int a)
        {
            Console.WriteLine(a);
            if (a < 3)
                loopRecursiva(a++);

            return a;
        }
    }
}
