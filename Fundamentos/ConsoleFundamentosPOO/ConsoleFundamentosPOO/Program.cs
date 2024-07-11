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
            //array e collections
            int[] numeros = new int[3]; //começa sempre por zero 0
            numeros[0] = 0;
            numeros[1] = 1;
            numeros[2] = 2;

            Console.WriteLine("Exibindo array de numero inteiro");
            Console.WriteLine($"Quantidade: {numeros.Length}");
            foreach (var n in numeros)
            {
                Console.WriteLine(n);
            }

            List<string> pessoas = new List<string>();
            pessoas.Add("Gabriel");
            pessoas.Add("Maria");
            pessoas.Add("Miguel");

            Console.WriteLine("Exibindo collection do tipo string");
            Console.WriteLine($"Quantidade: {pessoas.Count}");
            foreach (var item in pessoas)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
        
    }
}
