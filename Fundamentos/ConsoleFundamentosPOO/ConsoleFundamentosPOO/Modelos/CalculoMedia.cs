using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFundamentosPOO.Modelos
{
    public class CalculoMedia
    {
        public static void CalcularMediaAluno()
        {
            int qtdNotas = 3;
            string nomeAluno = string.Empty;

            Console.WriteLine("Digite o nome do aluno");
            nomeAluno = Console.ReadLine();

            Console.WriteLine($"Digite as {qtdNotas} notas do aluno");

            List<int> notas = new List<int>();
            int somaTotalNotas = 0;
            for (int i = 1; i <= qtdNotas; i++)
            {
                Console.WriteLine($"digite a nota número {i}");
                int nota = int.Parse(Console.ReadLine());
                notas.Add(nota);
                somaTotalNotas += nota;
            }

            var media = somaTotalNotas / qtdNotas;
            Console.WriteLine($"A média do aluno {nomeAluno} é: {media}");
        }
    }
}
