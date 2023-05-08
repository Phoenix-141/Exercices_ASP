using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExeRibeiroCipriano.Models
{
    public class Moto : veiculo
    {
        public int cilindrada { get; set; }
        public string categoria { get; set; }
    }
}