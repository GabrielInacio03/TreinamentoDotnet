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
        //propriedades
        public string Nome;
        public string Telefone;
        public string CPF;

        public static string CaminhoBaseClientes()
        {
            return ConfigurationManager.AppSettings["base_dos_clientes"];
        }
        public void Gravar()
        {
            //gravar cliente no arquivo txt
        }
        public static List<Cliente> LerClientes()
        {
            var clientes = new List<Cliente>();
            string pathUrlBase = CaminhoBaseClientes();
            if (File.Exists(pathUrlBase))
            {
                using (var arquivo = File.OpenText(pathUrlBase))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        //Console.WriteLine(linha);
                        clientes.Add(AdicionarClienteNaLista(linha));
                    }

                }
            }
            clientes.RemoveAt(0);
            return clientes;
        }
        public static Cliente AdicionarClienteNaLista(string linha)
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
