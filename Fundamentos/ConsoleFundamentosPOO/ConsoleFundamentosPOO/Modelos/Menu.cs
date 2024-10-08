﻿using ConsoleFundamentosPOO.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFundamentosPOO.Modelos
{
    public class Menu
    {
        private const string NOME_DO_PROGRAMA = "Curso Linguagem C#";
        private const int SAIDA_PROGRAMA = 0;
        private const int LER_ARQUIVOS = 1;
        private const int TABUADA = 2;
        private const int CALCULO_MEDIA = 3;
        private const int CADASTRAR_CLIENTE = 4;
        private const int LISTAR_CLIENTES = 5;
        private const int CADASTRAR_USUARIO = 6;
        private const int LISTAR_USUARIOS = 7;
        public static void MenuDeOpcoes()
        {
            string mensagem = "Olá usuário, bem vindo ao program, utilizando programação funcional" +
                "\nDigite uma das opções abaixo:" +
                "\n0 - sair" +
                "\n1 - Ler Arquivos" +
                "\n2 - Tabuada" +
                "\n3 - Calcular" +
                "\n4 - Cadastrar Cliente" +
                "\n5 - Listar Clientes" +
                "\n6 - Cadastrar Usuarios"+
                "\n7 - Listar Usuários";
            while (true)
            {
                Console.WriteLine("=====================================");
                Console.WriteLine(mensagem);
                Console.WriteLine("=====================================");
                int valor = int.Parse(Console.ReadLine());

                if (SAIDA_PROGRAMA == valor)
                {
                    break;
                }
                else if (LER_ARQUIVOS == valor)
                {
                    Arquivos.LerArquivos(1);
                }
                else if (TABUADA == valor)
                {
                    Console.WriteLine("qual tabuada deseja ser exibida ?");
                    int tab = int.Parse(Console.ReadLine());
                    Tabuada.GerarTabuada(tab);
                }
                else if (CALCULO_MEDIA == valor)
                {
                    CalculoMedia.CalcularMediaAluno();
                }
                else if(CADASTRAR_CLIENTE == valor)
                {
                    Console.WriteLine("Informe o nome do cliente: ");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Informe o telefone do cliente: ");
                    string tel = Console.ReadLine();

                    Console.WriteLine("Informe o cpf do cliente: ");
                    string cpf = Console.ReadLine();

                    Cliente cliente = new Cliente(nome, tel, cpf);
                    cliente.Gravar();
                }
                else if(LISTAR_CLIENTES == valor)
                {
                    Console.WriteLine("CLIENTES >>>");
                    Cliente cliente = new Cliente();
                    cliente.ListarNaTela();
                }else if(CADASTRAR_USUARIO == valor)
                {
                    
                    Console.WriteLine("Informe o nome do cliente: ");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Informe o telefone do cliente: ");
                    string tel = Console.ReadLine();

                    Console.WriteLine("Informe o cpf do cliente: ");
                    string cpf = Console.ReadLine();

                    Usuario usuario = new Usuario { Nome = nome, CPF = cpf, Telefone = tel};

                    usuario.Gravar();
                }
                else if (LISTAR_USUARIOS == valor)
                {
                    Console.WriteLine("USUARIOS >>>");
                    Usuario usuario = new Usuario();
                    usuario.ListarNaTela();
                }
                else
                {
                    Console.WriteLine("Opções, a opção digitada não existe!");
                }
            }
        }
    }
}
