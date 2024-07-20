using ConsoleFundamentosPOO.Classes;
using ConsoleFundamentosPOO.Modelos;
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
        static void Main(string[] args)
        {
            var listaClientes = Cliente.LerClientes();

            foreach (var item in listaClientes)
            {
                Console.WriteLine($"Nome Cliente: {item.Nome}");
            }

            Console.Read();
        }
                       
    }
}
