using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace roupabox
{
    internal class Clientes
    {
        List<ClienteCad> listaClientes = new List<ClienteCad>();

        public ClienteCad cadCliente()
        {
            Console.Clear();
            Console.WriteLine("Cadastro  de clientes");

            Console.WriteLine("\n Digite o nome completo do cliente: ");
            string nomeCli = Console.ReadLine();


            var Cliente = new ClienteCad(nomeCli);


            Console.WriteLine("\n Digite o CPF do cliente (somente numeros): "); //11 digitos 
            string cpfCli = Console.ReadLine();
            Cliente.cpfCli = cpfCli;

            while (cpfCli.Length != 11 || !cpfCli.All(char.IsDigit)) {
                // !cpfCli.All(char.IsDigit = para aceitar somente caracteres numericos
                Console.WriteLine("CPF inválido, tente novamente!");
                cpfCli = Console.ReadLine();
                Cliente.cpfCli = cpfCli;
            }
 

            Console.WriteLine("\n Digite o telefone do cliente (somente numeros com DDD): "); //11 digitos com ddd
            string telCli = Console.ReadLine();
            Cliente.telCli = telCli;

            while (telCli.Length != 11 || !telCli.All(char.IsDigit))
            {
                Console.WriteLine("Numero inválido, tente novamente!");
                telCli = Console.ReadLine();
                Cliente.telCli = telCli;
            }

            Console.WriteLine("\n Digite a idade do cliente: ");
            int idadeCli = int.Parse(Console.ReadLine());
            Cliente.idadeCli = idadeCli;

            Console.WriteLine("\n Digite o email do cliente: ");
            string emailCli = Console.ReadLine();
            Cliente.emailCli = emailCli;

            while (!emailCli.Contains("@")) // verifica se contem um @ dentro da variavel email; 
            {
                Console.WriteLine("O endereço de e-mail não é válido, tente novamente!");
                emailCli = Console.ReadLine(); // coloco para receber variavel novamente, para nao dar um loop infintito;
                Cliente.emailCli = emailCli;
            }  
            
                Console.WriteLine("\n Digite o sexo do cliente:");
            string sexoCli = Console.ReadLine();
            Cliente.sexoCli= sexoCli;

            Console.WriteLine("\n Digite a rua / avenida do cliente: ");
            string ruaCli = Console.ReadLine();
            Cliente.ruaCli = ruaCli;

            Console.WriteLine("\n Digite o complemento da rua, caso tenha: ");
            string complCli = Console.ReadLine();
            Cliente.compCli = complCli;

            Console.WriteLine("\n Digite o numero da casa do cliente: ");
            int numCli = int.Parse(Console.ReadLine());
            Cliente.numCli = numCli;

            Console.WriteLine("\n Digite o bairro do cliente: ");
            string bairroCli = Console.ReadLine();
            Cliente.bairroCli = bairroCli;

            Console.WriteLine("\n Digite a cidade do cliente: ");
            string cidCli = Console.ReadLine();
            Cliente.cidCli = cidCli;

            Console.WriteLine("\n Digite o estado do cliente: "); // somente 2 digitos 
            string estCli = Console.ReadLine();
            Cliente.estCli = estCli;

            Console.WriteLine("\n Digite o cep do cliente: ");//somente 8 digitos 
            long cepCli = long.Parse(Console.ReadLine());
            Cliente.cepCli = cepCli;

            Console.WriteLine("\n Cliente cadastrado com sucesso!!!");
            Console.WriteLine("\n Digite uma tecla para voltar ao menu principal!");
            Console.ReadKey(); // ele fica parado na tela ate a pessoa finalizar o cadastro; 

            Console.Clear();

            Cabecalho varcabecalho = new Cabecalho();
            varcabecalho.cabecalho();

            Clientes varCli = new Clientes();


            ExibirMenu varmenu = new ExibirMenu();

            return Cliente;
        }

        public void listarCliente()
        {
            Console.Clear();
            Console.WriteLine("Lista de clientes Cadastrados");

            foreach (var cliente in listaClientes)
            {
                Console.WriteLine($"Nome: {cliente.nomeCli}, " + $"telefone: {cliente.telCli}" + $"cpf: {cliente.cpfCli}");
            }

            Console.WriteLine("\n Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();

            Cabecalho variavelCabecalho = new Cabecalho();
            variavelCabecalho.cabecalho();

            Clientes varCli = new Clientes();
            ExibirMenu variavelMenu = new ExibirMenu();

        }


    }
}
