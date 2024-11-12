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

            Menu varmenu = new Menu();
            varmenu.menu();



        }
    }
}
