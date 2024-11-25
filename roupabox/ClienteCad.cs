using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roupabox
{
    internal class ClienteCad
    {

        public ClienteCad(string cli) // pro = produto 
        {
            nomeCli = cli; // aqui ele associa o desc pro como pro então ele fica como principal por conta desse primeiro;
        }

        public string nomeCli { get; set; } // associar e armazenar as informaçoes da variavel; 
        public string cpfCli { get; set; }
        public string telCli { get; set; }
        public int idadeCli { get; set;  }
        public string emailCli { get; set; }
        public string sexoCli { get; set;}
        public string ruaCli { get; set; }
        public string compCli { get; set; }
        public int numCli { get; set; }
        public string bairroCli { get; set; }
        public string cidCli { get; set; }
        public string estCli { get; set; }
        public long cepCli { get; set; }

    }
}
