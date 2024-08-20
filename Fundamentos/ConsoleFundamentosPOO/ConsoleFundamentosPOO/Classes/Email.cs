using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFundamentosPOO.Classes
{
    public class Email
    {
        //construtor privado não consigo criar uma instância 
        private Email() { }

        private static Email instancia;
        public  string Origin;
        public  string Destino;
        public  string Titulo;
        public  string Corpo;

        public  void EnviarEmail()
        {
            Console.WriteLine($"Enviando Email para {Destino} \n Com o titulo: {Titulo} \n e corpo: {Corpo}");
        }
        public static Email Instancia
        {
            get
            {
                if(instancia == null)
                {
                    instancia = new Email();
                }
                return instancia;
            }
        }
    }
}
