using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enel
{
    class Stampa
    {
        public string StampaDati(string nome, string cognome, decimal costo)
        {
            return $"il Cliente {nome} {cognome} ha speso {costo}";
        }
    }
}
