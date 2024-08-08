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

            //gravar
            Cliente cliente = new Cliente("TesteGravacao", "1212221212", "133131331");
            cliente.Gravar(cliente);
            Console.Read();
        }
                       
    }
}
