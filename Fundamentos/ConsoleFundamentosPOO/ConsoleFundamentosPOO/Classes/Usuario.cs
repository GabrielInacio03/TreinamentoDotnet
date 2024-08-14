using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFundamentosPOO.Classes
{
    public class Usuario : Cliente
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public Usuario() { }
        public Usuario(string Login, string Senha)
        {
            this.Login = Login;
            this.Senha = Senha;
        }
        public Usuario(string nome, string telefone, string cPF) : base(nome, telefone, cPF)
        {
        }
        public static string CaminhoBaseUsuarios()
        {
            return ConfigurationManager.AppSettings["base_dos_usuarios"];
        }
        
    }
}
