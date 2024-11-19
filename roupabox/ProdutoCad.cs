using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roupabox
{
    internal class ProdutoCad
    {

        public ProdutoCad(string pro) // pro = produto 
        {
            descPro = pro; // aqui ele associa o desc pro como pro então ele fica como principal por conta desse primeiro;
        }

        public string descPro { get; set; } // associar e armazenar as informaçoes da variavel; 
        public string pro { get; set; }
        public string marcaPro { get; set; }
        public string tamPro { get; set;  }
        public string corPro { get; set; }
        public string catPro { get; set;}
        public double valPro { get; set; }
        public double pesoPro { get; set; }

    }
}
