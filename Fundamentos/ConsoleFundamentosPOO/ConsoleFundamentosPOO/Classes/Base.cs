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
    public class Base : IPessoa
    {
        //propriedades
        public string Nome;
        public string Telefone;
        public string CPF;
        public static string CaminhoBase(String nome)
        {
            if(nome == "Cliente")
                return ConfigurationManager.AppSettings["base_dos_clientes"];
            else
                return ConfigurationManager.AppSettings["base_dos_usuarios"];
        }
        public virtual string ConstruirLinha()
        {
            return this.Nome + ";" + this.Telefone + ";" + this.CPF + ";";
        }
        public virtual void Gravar()
        {
            this.Olhar();
            string linha = ConstruirLinha();
            using (StreamWriter sw = new StreamWriter(CaminhoBase(this.GetType().Name), true))
            {
                if (linha != null)
                    sw.WriteLine(linha);

                sw.Close();
            }
        }
        private void Olhar()
        {
            Console.WriteLine($"gravando...");
        }
        public void ListarNaTela()
        {
            foreach (var item in Ler(this.GetType().Name))
            {
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine($"Nome: {item.Nome}, Telefone: {item.Telefone}, CPF: {item.CPF};");
            }
        }
        public static List<Base> Ler(string nomeCaminho)
        {
            string pathUrlBase = Base.CaminhoBase(nomeCaminho);
            var bases = new List<Base>();
            if (File.Exists(pathUrlBase))
            {
                using (var arquivo = File.OpenText(pathUrlBase))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        //Console.WriteLine(linha);
                        bases.Add(AdicionarNaLista(linha));
                    }

                }
            }
            bases.RemoveAt(0);
            return bases;
        }
        public static Base AdicionarNaLista(string linha)
        {
            //3 posições
            var linhaArray = linha.Split(';').ToArray();
            Base cliente = new Base();
            cliente.Nome = linhaArray[0];
            cliente.Telefone = linhaArray[1];
            cliente.CPF = linhaArray[2];

            return cliente;
        }
    }
}
