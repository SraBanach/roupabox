using System;
using System.Collections.Generic;
using System.Linq;
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
            double valPro = double.Parse(Console.ReadLine());

            Console.WriteLine("\n Peso:");
            double pesoPro = double.Parse(Console.ReadLine());








        }

    }
}
