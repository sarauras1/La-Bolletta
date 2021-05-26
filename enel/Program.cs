
//Realizzare un’applicazione console che consenta di
//eseguire il calcolo della bolletta della luce.


//Si richiede di sviluppare un menù attraverso cui
//l’utente può scegliere di:




// inserire i propri dati (nome, cognome e kwH consumati);
//richiedere il calcolo del costo della bolletta che è costituito da una quota fissa di 40€ più il prodotto tra i kwH e 10.
//		 stampare a video i valori della bolletta, inclusi nome, cognome e costo pagato.
//	Realizzare un’applicazione console che consenta di eseguire il calcolo della bolletta della luce.

//Si richiede di sviluppare un menù attraverso cui l’utente può scegliere di:

// inserire i propri dati (nome, cognome e kwH consumati);
//richiedere il calcolo del costo della bolletta che è
//costituito da una quota fissa di 40€ più il prodotto tra
//i kwH e 10.

//stampare a video i valori della bolletta, inclusi nome,
//cognome e costo pagato.

//Ciascuna delle operazioni descritte sopra dovrà
//essere implementata attraverso una opportuna routine.



using System;

namespace enel
{
	class Program
	{
		static void Main(string[] args)
		{

			Bolletta bolletta = new Bolletta();
            Utente u = new Utente();




            bool esci = false;
           

             
                 
            	do
            	{

            		Console.WriteLine("Scegli un opzione:");
            	    Console.WriteLine("A per inserire i tuoi dati");
            		Console.WriteLine("B per effetuare il calcolo bolletta");
            	    Console.WriteLine("C per visualizzare il risulato calcolo bolletta");
            		Console.WriteLine("D per uscire");


            switch (Console.ReadKey().KeyChar)
            {
                case 'A':
                 InserisciDati(ref bolletta, ref u);
                        
                        break;
                case 'B':
                   CalcoloBolletta(ref bolletta);
                    break;
                case 'C':
                  StampaDati(bolletta, u);
                    break;
                case 'D':
                    esci = true;
                    break;
            }
        } while(!esci);


          
        }
        private static void InserisciDati(ref Bolletta bolletta, ref Utente u)
        {
           

            Console.WriteLine("Inserisci i dati della tua bolletta");
            do
            {
                Console.WriteLine("Inserisci nome");
                u.Nome = Console.ReadLine();
                Console.WriteLine("Inserisci cognome");
                u.Cognome = Console.ReadLine();
                Console.WriteLine("Inserisci consumo");
                bolletta.Consumo = double.Parse(Console.ReadLine());
            } while (u.Nome == null || u.Cognome == null || bolletta.Consumo <= 0);
            

        }
        private static void CalcoloBolletta(ref Bolletta Bolletta)
        {
           
            double prodotto = Bolletta.Consumo * 10;
            Bolletta.Costo = (decimal)prodotto + Bolletta.Quota;
            Console.WriteLine("Fatto");
        }

        private static void StampaDati(Bolletta bolletta, Utente u )
        {
           
            Console.WriteLine($"il Cliente {u.Nome} {u.Cognome} ha speso {bolletta.Costo}");
        }


    }
}
