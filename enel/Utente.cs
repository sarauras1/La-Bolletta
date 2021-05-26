using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enel
{
   public class Utente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
      
      

        public Utente (string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
         
        }

        public Utente()
        {
           
        }

       
    }
}
