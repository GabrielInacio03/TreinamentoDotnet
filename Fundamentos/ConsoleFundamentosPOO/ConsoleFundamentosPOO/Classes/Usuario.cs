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
        public static string CaminhoBase()
        {
            return ConfigurationManager.AppSettings["base_dos_usuarios"];
        }
        public static string ConstruirLinha(Usuario usuario)
        {
            return usuario.Login + ";" + usuario.Senha + ";" + usuario.Nome + ";" + usuario.Telefone + ";" + usuario.CPF + ";";
        }
        public void Gravar()
        {
            string linha = ConstruirLinha(this);

            using (StreamWriter sw = new StreamWriter(Usuario.CaminhoBase(), true))
            {
                if (linha != null)
                    sw.WriteLine(linha);

                sw.Close();
            }
        }
        public static void ListarNaTela()
        {
            foreach (var item in Ler())
            {
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine($"Login: {item.Login}, Senha: {item.Senha}, Nome: {item.Nome}, Telefone: {item.Telefone}, CPF: {item.CPF};");
            }
        }
        public static List<Usuario> Ler()
        {
            string pathUrlBase = CaminhoBase();
            var usuarios = new List<Usuario>();
            if (File.Exists(pathUrlBase))
            {
                using (var arquivo = File.OpenText(pathUrlBase))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        //Console.WriteLine(linha);
                        usuarios.Add(AdicionarNaLista(linha));
                    }

                }
            }
            usuarios.RemoveAt(0);
            return usuarios;
        }
        public static Usuario AdicionarNaLista(string linha)
        {
            //3 posições
            var linhaArray = linha.Split(';').ToArray();
            Usuario usuario = new Usuario();
            usuario.Login = linhaArray[0];
            usuario.Senha = linhaArray[1];
            usuario.Nome = linhaArray[2];
            usuario.Telefone = linhaArray[3];
            usuario.CPF = linhaArray[4];

            return usuario;
        }
    }
}
