using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFundamentosPOO.Classes
{
    public class Cliente
    {
       /// <summary>
       /// sealed -> não pode sobreescrever
       /// </summary>
        //propriedades
        public string Nome;
        public string Telefone;
        public string CPF;

        /// <summary>
        /// Construtor da classev
        /// </summary>
        public Cliente() { }

        /// <summary>
        /// Construtor com parametros
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="telefone"></param>
        /// <param name="cPF"></param>
        public Cliente(string nome, string telefone, string cPF)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.CPF = cPF;
        }

        public static string CaminhoBase()
        {
            return ConfigurationManager.AppSettings["base_dos_clientes"];
        }
        
        public virtual void Gravar() //virtual -> pode ser sobreescrito
        {
            this.Olhar();
            string linha = ConstruirLinha(this);

            using (StreamWriter sw = new StreamWriter(CaminhoBase(), true))
            {
                if (linha != null)
                    sw.WriteLine(linha);

                sw.Close();
            }
        }
        
        private void Olhar()
        {
            Console.WriteLine($"O cliente {this.CPF} esta sendo gravado");
        }
        
        public virtual string ConstruirLinha(Cliente cliente)
        {
            return cliente.Nome+";"+cliente.Telefone+";"+cliente.CPF+";";
        }
        public static void ListarNaTela()
        {
            foreach (var item in Ler())
            {
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine($"Nome: {item.Nome}, Telefone: {item.Telefone}, CPF: {item.CPF};");
            }
        }
        public static List<Cliente> Ler()
        {
            string pathUrlBase = CaminhoBase();
            var clientes = new List<Cliente>();
            if (File.Exists(pathUrlBase))
            {
                using (var arquivo = File.OpenText(pathUrlBase))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        //Console.WriteLine(linha);
                        clientes.Add(AdicionarNaLista(linha));
                    }

                }
            }
            clientes.RemoveAt(0);
            return clientes;
        }

        public static Cliente AdicionarNaLista(string linha)
        {
            //3 posições
            var linhaArray = linha.Split(';').ToArray();
            Cliente cliente = new Cliente();
            cliente.Nome = linhaArray[0];
            cliente.Telefone = linhaArray[1];
            cliente.CPF = linhaArray[2];

            return cliente;
        }
    }
}
