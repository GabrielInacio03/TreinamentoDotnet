﻿using System;
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

        public static string CaminhoBaseClientes()
        {
            return ConfigurationManager.AppSettings["base_dos_clientes"];
        }
        public void Gravar(Cliente cliente)
        {
            string linha = ConstruirLinha(cliente);
            
            using(StreamWriter sw = new StreamWriter(CaminhoBaseClientes(), true))
            {
                if (linha != null)
                    sw.WriteLine(linha);
            }
            
                
        }
        public string ConstruirLinha(Cliente cliente)
        {
            return cliente.Nome+";"+cliente.Telefone+";"+cliente.CPF+";";
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
