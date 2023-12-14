using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backmoney_DaniloZivanovic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Déclarations des variables ////

            uint somme;   // Variable qui stockera la valeur "Somme" rentrer par l'utilisateur 
            bool valueOk = true;

            //// Programme Principal //// 

            // Affichage du titre
            Console.WriteLine("╔═════════════════════════════════════════════════╗");
            Console.WriteLine("║Bienvenue dans le programme de retour de monnaie ║");
            Console.WriteLine("║Réalisé par Danilo Zivanovic                     ║");
            Console.WriteLine("╚═════════════════════════════════════════════════╝");

            // Affichage des restrictions
            Console.WriteLine("\n\nMerci d'entrer la somme d'argent à décomposer");
            Console.WriteLine("en sachant que la somme ne dois pas :");

            // Assigne les couleurs rouges aux mots "négative" "zéro" et "uint" puis reset les couleurs
            Console.Write("\t être "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("négative"); Console.ResetColor(); Console.WriteLine();
            Console.Write("\t être égal à "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("zéro"); Console.ResetColor(); Console.WriteLine(" donc > 0");
            Console.Write("\t pas dépasser la taille d'un "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("uint"); Console.ResetColor(); Console.WriteLine();

            do
            {
                Console.Write("\n\nVotre somme: ");
                string input = Console.ReadLine(); 

                if (!uint.TryParse(input, out somme))
                {
                    Console.WriteLine("\nVotre valeur n'est pas un nombre ou n'est pas dans la limite d'un uint ! Merci de réessayer !");
                }
                else
                {
                    valueOk = false; // Permet de sortir de la boucle si la conversion est juste
                }

            } while (valueOk);

            Console.ReadLine();
        }
    }
}
