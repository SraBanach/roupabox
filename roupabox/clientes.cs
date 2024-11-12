using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace roupabox
{
    internal class clientes
    {

        public void cadCliente()
        {
            Console.Clear();
            Console.WriteLine("Cadastro  de clientes");

            Console.WriteLine("\n Digite o nome completo do cliente: ");
            string nomeCli = Console.ReadLine();

            Console.WriteLine("\n Digite o CPF do cliente: ");
            long cpfCli = long.Parse (Console.ReadLine());
            
         //   string input = "123456"; Console.ReadLine();
         //   bool isNumeric = Regex.IsMatch(input, @"^\d+$");

            Console.WriteLine("\n Digite o telefone do cliente: ");
            long telCli = long.Parse(Console.ReadLine());

            Console.WriteLine("\n Digite a idade do cliente: ");
            int idadeCli = int.Parse(Console.ReadLine());

            Console.WriteLine("\n Digite o email do cliente: ");
            string emailCli = Console.ReadLine();

            Console.WriteLine("\n Digite o sexo do cliente:");
            string sexoCli = Console.ReadLine();

            Console.WriteLine("\n Digite a rua / avenida do cliente: ");
            string ruaCli = Console.ReadLine();

            Console.WriteLine("\n Digite o complemento da rua, caso tenha: ");
            string complCli = Console.ReadLine();

            Console.WriteLine("\n Digite o numero da casa do cliente: ");
            string numCli = Console.ReadLine();

            Console.WriteLine("\n Digite o bairro do cliente: ");
            string bairroCli = Console.ReadLine();

            Console.WriteLine("\n Digite a cidade do cliente: ");
            string cidCli = Console.ReadLine();

            Console.WriteLine("\n Digite o estado do cliente: ");
            string estCli = Console.ReadLine();

            Console.WriteLine("\n Digite o cep do cliente: ");
            long cepCli = long.Parse(Console.ReadLine());

            Console.WriteLine("\n Cliente cadastrado com sucesso!!!");
            Console.WriteLine("\n Digite uma tecla para voltar ao menu principal!");
            Console.ReadKey(); // ele fica parado na tela ate a pessoa finalizar o cadastro; 

            Console.Clear();

            Cabecalho varcabecalho = new Cabecalho();
            varcabecalho.cabecalho();

            Menu varmenu = new Menu();
            varmenu.menu();



        }


    }
}
