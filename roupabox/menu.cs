using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace roupabox
{
    internal class ExibirMenu
    {
        public void Menu(Produtos varPro, Clientes varCli) // adc para listar = para levar as informacoes do menu para dentro do program (parametro)
        {

            List<ProdutoCad> listaP = new List<ProdutoCad>();
            List<ClienteCad> listaC = new List<ClienteCad>();
            //puxa o nome do internal class  ProdutosCad 
            // Produtos vem do program o new Program 
            while (true) { 
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
                    varCli.cadCliente();
                        break;

                case 2 :
                        varCli.listarCliente();
                        break;

                case 3 :
                    varPro.cadProduto();
                        break;

                case 4 :
                        varPro.listarProdutos();
                        break;
                default:
                    Console.WriteLine("Digite uma opção válida!");
                    Thread.Sleep(1000);
                    Console.Clear();
                     break;

            }
            }


        }

    }
}
