using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roupabox
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Cabecalho varcabecalho = new Cabecalho();
            varcabecalho.cabecalho();

            Produtos varPro = new Produtos(); // parte que precisa adicionar quando vou precisar listar produtos; 
            Clientes varCli = new Clientes(); // parte que precisa adicionar quando vou listar produtos; 


            ExibirMenu varmenu = new ExibirMenu();
            varmenu.Menu(varPro); // add varPro para que ele pegue a referencia de produto; 



        }
    }
}
