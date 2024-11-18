using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace roupabox
{
    internal class produtos
    {

        public void cadProduto()
        {

            Console.Clear();
            Console.WriteLine("Cadastro de produtos");

            Console.WriteLine("\n Digite a marca do produto: ");
            string marcaPro = Console.ReadLine();

            Console.WriteLine("\n Tamanho:");
            string tamPro = Console.ReadLine();

            Console.WriteLine("\n Qual a cor do produto?");
            string corPro = Console.ReadLine();

            Console.WriteLine("\n Categoria: ");
            string catPro = Console.ReadLine();

            Console.WriteLine("\n descrição: ");
            string descPro = Console.ReadLine();

            Console.WriteLine("\n valor:");
            while (!double.TryParse(Console.ReadLine(), out double valPro)) //verificar se o valor esta com numeros mesmo; 
            {
                Console.WriteLine("Valor inválido. Tente novamente.");
             
            }

            Console.WriteLine("\n Peso:");
            while (!double.TryParse(Console.ReadLine(), out double pesoPro)) // verificar se esta em peso mesmo; 
            {
                Console.WriteLine("Peso inválido. Tente novamente.");
             
            }

            Console.WriteLine("\n Produto cadastrado com sucesso!");
            Console.WriteLine("\n Digite qualquer tecla para voltar o menu principal.");
            Console.ReadKey(); // tela estatica ate receber a resposta. 

            Console.Clear();

            Cabecalho varcabecalho = new Cabecalho();
            varcabecalho.cabecalho();

            Menu varmenu = new Menu();
            varmenu.menu();








        }

    }
}
