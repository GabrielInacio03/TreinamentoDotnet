using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFundamentosPOO.Modelos
{
    public class Tabuada
    {
        public static void GerarTabuada(int numeroTab)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numeroTab} x {i} = {numeroTab * i}");
            }
        }

    }
}
