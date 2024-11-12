using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace roupabox
{
    internal class Menu
    {

        public void menu()
        {

            Console.WriteLine("Digite 0 para sair ");
            Console.WriteLine("Digite 1 para cadastro de clientes");
            Console.WriteLine("Digite 2 para listar clientes");
            Console.WriteLine("Digite 3 para cadastro de produtos");
            Console.WriteLine("Digite 4 para listar produtos");

            Console.WriteLine("Digite a opção escolhida: ");

            int  opcaoEscolhida = int.Parse(Console.ReadLine());

            switch (opcaoEscolhida)
            {
                case 0: 
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\r\n░██████╗░█████╗░██╗███╗░░██╗██████╗░░█████╗░\r\n██╔════╝██╔══██╗██║████╗░██║██╔══██╗██╔══██╗\r\n╚█████╗░███████║██║██╔██╗██║██║░░██║██║░░██║\r\n░╚═══██╗██╔══██║██║██║╚████║██║░░██║██║░░██║\r\n██████╔╝██║░░██║██║██║░╚███║██████╔╝╚█████╔╝\r\n╚═════╝░╚═╝░░╚═╝╚═╝╚═╝░░╚══╝╚═════╝░░╚════╝░");
                    Console.ResetColor();
                    break;

                case 1 : 
                    clientes varCli = new clientes();
                    varCli.cadCliente();
                    Console.WriteLine();

                        break;

                case 2 : Console.WriteLine();

                        break;

                case 3 : Console.WriteLine();

                        break;

                case 4 : Console.WriteLine();

                        break;
                default:
                    Console.WriteLine("Digite uma opção válida!");
                    Thread.Sleep(1000);
                    Console.Clear();

                    Cabecalho varcabecalho = new Cabecalho();
                    varcabecalho.cabecalho();

                    Menu varmenu = new Menu();
                    varmenu.menu();

                    break;

            }


        }

    }
}
