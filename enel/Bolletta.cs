using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enel
{
   public class Bolletta

      
    {
        public decimal Quota { get; set; } = 40;
        public decimal Costo { get; set; } = 0;
        public double Consumo { get; set; } = 0;
        public Utente Utente { get; set; }
        public Bolletta(decimal costo, decimal quota, double consumo)
        {
            Costo = costo;
            Consumo = consumo;
            Quota = quota;

        }

        public Bolletta()
        {

        }

    }
}
