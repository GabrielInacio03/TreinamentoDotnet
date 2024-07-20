using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFundamentosPOO.Modelos
{
    public class Arquivos
    {
        public static void LerArquivos(int numeroArquivo)
        {
            string caminhoArquivos = ConfigurationManager.AppSettings["caminho_arquivos"];
            string pathUrlBase = caminhoArquivos + $"arq{numeroArquivo}.txt";
            if (File.Exists(pathUrlBase))
            {
                using (var arquivo = File.OpenText(pathUrlBase))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }

                }
            }

            string pathUrlBaseProximo = caminhoArquivos + $"arq{numeroArquivo + 1}.txt";
            if (File.Exists(pathUrlBaseProximo))
                LerArquivos(numeroArquivo + 1);
        }
    }
}
