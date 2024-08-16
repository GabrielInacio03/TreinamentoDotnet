using ConsoleFundamentosPOO.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFundamentosPOO.Classes
{
    public class Cliente : Base
    {
        public Cliente() { }
        public Cliente(string nome, string telefone, string cPF)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.CPF = cPF;
        }
        
    }
}
