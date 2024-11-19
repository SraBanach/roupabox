﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace roupabox
{
    internal class Produtos
    {
        List<ProdutoCad> listaProdutos = new List<ProdutoCad>(); //adc

        public ProdutoCad cadProduto()
        {



            Console.Clear();
            Console.WriteLine("Cadastro de produtos");

            Console.WriteLine("\n descrição: ");
            string descPro = Console.ReadLine();

            var Produto = new ProdutoCad(descPro); //adc = para criar uma nova variavel com um novo produto;

            Console.WriteLine("\n Digite a marca do produto: ");
            string marcaPro = Console.ReadLine(); //
            Produto.marcaPro = marcaPro; // associar o produto ao marcaPro

            Console.WriteLine("\n Tamanho:");
            string tamPro = Console.ReadLine();
            Produto.tamPro = tamPro; // associar o produto ao tamPro; 

            Console.WriteLine("\n Qual a cor do produto?");
            string corPro = Console.ReadLine();
            Produto.corPro = corPro; // Linha para associar o produto ao corPro;

            Console.WriteLine("\n Categoria: ");
            string catPro = Console.ReadLine();
            Produto.catPro = catPro; //Linha para associar o produto ao catPro;

            Console.WriteLine("\n valor:");
            while (!double.TryParse(Console.ReadLine(), out double valPro)) //verificar se o valor esta com numeros mesmo; 
            {
                Produto.valPro = valPro;
                Console.WriteLine("Valor inválido. Tente novamente.");
             
            }
            

            Console.WriteLine("\n Peso:");
            while (!double.TryParse(Console.ReadLine(), out double pesoPro)) // verificar se esta em peso mesmo; 
            {
                Produto.pesoPro = pesoPro;
                Console.WriteLine("Peso inválido. Tente novamente.");
             
            }

            listaProdutos.Add(Produto);

            Console.WriteLine("\n Produto cadastrado com sucesso!");


            //foreach = faca enquanto
            foreach (var produto in listaProdutos) 
            { 
                Console.WriteLine($"Descrição: {produto.descPro}, " + $"Valor: {produto.valPro}"); 
            }    


            Console.WriteLine("\n Digite qualquer tecla para voltar o menu principal.");
            Console.ReadKey(); // tela estatica ate receber a resposta. 

            Console.Clear();

            Cabecalho varcabecalho = new Cabecalho();
            varcabecalho.cabecalho();

            Produtos varPro = new Produtos(); // parte que precisa adicionar quando vou precisar listar produtos; 
            ExibirMenu varmenu = new ExibirMenu();

            return Produto;



        }

    }
}
