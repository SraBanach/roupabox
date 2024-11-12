using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roupabox
{
    internal class Cabecalho
    {

        public void cabecalho()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("════════════════════════════════");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Autor(a): Kênya Banach");

            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("════════════════════════════════");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
██████╗░░█████╗░██╗░░░██╗██████╗░░█████╗░██████╗░░█████╗░██╗░░██╗
██╔══██╗██╔══██╗██║░░░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗╚██╗██╔╝
██████╔╝██║░░██║██║░░░██║██████╔╝███████║██████╦╝██║░░██║░╚███╔╝░
██╔══██╗██║░░██║██║░░░██║██╔═══╝░██╔══██║██╔══██╗██║░░██║░██╔██╗░
██║░░██║╚█████╔╝╚██████╔╝██║░░░░░██║░░██║██████╦╝╚█████╔╝██╔╝╚██╗
╚═╝░░╚═╝░╚════╝░░╚═════╝░╚═╝░░░░░╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("════════════════════════════════");
            Console.ResetColor();

        }

    }
}
