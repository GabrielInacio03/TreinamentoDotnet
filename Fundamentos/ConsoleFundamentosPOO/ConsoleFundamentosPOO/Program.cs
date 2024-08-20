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
        public int idade; //atributo
        private string vacinou = "true";

        public string Raca { get; set; } //propriedade
        public bool IsVacina { get { return (vacinou.Equals("true")) ? true : false; } }
        public string Origem { get; private set; }
        public override void Latir()
        {
            Console.WriteLine("Cachorro latindo... AUHAUHAUH");
        }
        public void DefinirOrigem()
        {
            this.Origem = "Brasil";
        }
    }

    class Program
    {        
        static void Main(string[] args)
        {
            Email.Instancia.Origin = "teste@gmail.com";
            Email.Instancia.Titulo = "TESTE";
            Email.Instancia.Corpo = "TESTANDO ENVIO";
            Email.Instancia.Destino = "teste123@gmail.com";
            Email.Instancia.EnviarEmail();
            //Sistema
            Menu.MenuDeOpcoes();

        }
                       
    }
}
