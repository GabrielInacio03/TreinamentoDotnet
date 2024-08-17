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
    public abstract class Animal 
    {
        public string Nome { get; set; }
        public string Cor { get; set; }
        public string Tamanho { get; set; }

        public abstract void Latir();
        public string Correr()
        {
            return "Animal esta correndo";
        }
    }
    public class Cachorro : Animal
    {
        public override void Latir()
        {
            Console.WriteLine("Cachorro latindo... AUHAUHAUH");
        }
    }

    class Program
    {        
        static void Main(string[] args)
        {
            //Sistema
            Menu.MenuDeOpcoes();

        }
                       
    }
}
