using ConsoleFundamentosPOO.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFundamentosPOO.Classes
{
    public class Base : IPessoa
    {
        public static string CaminhoBase()
        {
            return ConfigurationManager.AppSettings["base_dos_usuarios"];
        }
        public virtual string ConstruirLinha()
        {
            throw new NotImplementedException();
        }

        public virtual void Gravar()
        {
            throw new NotImplementedException();
        }
    }
}
