// Commentaire N°1
// Commentaire N°2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TP1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Saisir l'argent :");
            string argentSaisie = Console.ReadLine();

            int argent = Convert.ToInt32(argentSaisie);

            if (argent > 100)
            {
                Console.WriteLine(argent / 100 + " billet(s) de 100");
                argent = argent % 100;
            }
            else
            {
                Console.WriteLine("0 billet(s) de 100");
            }
            if (argent > 50)
            {
                Console.WriteLine(argent / 50 + " billet(s) de 50");
                argent = argent % 50;
            }
            else
            {
                Console.WriteLine("0 billet(s) de 50");
            }
            if (argent > 10)
            {
                Console.WriteLine(argent / 10 + " billet(s) de 10");
                argent = argent % 10;
            }
            else
            {
                Console.WriteLine("0 billet(s) de 10");
            }
            if (argent > 5)
            {
                Console.WriteLine(argent / 5 + " billet(s) de 5");
                argent = argent % 10;
            }
            else
            {
                Console.WriteLine("0 billet(s) de 5");
            }
            if (argent >= 1)
            {
                Console.WriteLine(argent + " pièces(s) de 1");
            }
            else
            {
                Console.WriteLine("0 pièces(s) de 1");
            }
        }
    }
}
