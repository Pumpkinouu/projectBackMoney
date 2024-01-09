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

            do
            {
                Console.Clear();

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
                Console.Write("\t pas dépasser la taille d'un "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("uint\n"); Console.ResetColor(); Console.WriteLine();

                do
                {
                    Console.Write("\nVotre somme: ");
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

                decomposerMonnaie(somme);

                Console.Write("\n\nVoulez-vous recommencer ? (o / n): ");

            } while (Console.ReadLine().ToLower() == "o");

            Console.ReadLine();
        }

        /// <summary>
        /// Fonction pour décomposer la somme rentré par l'utilisateur
        /// </summary>
        /// <param name="somme"></param>
        static void decomposerMonnaie(uint somme1)
        {
            int[] billets = { 1000, 500, 200, 100, 50, 20, 10 };
            int[] pieces = { 5, 2, 1 };

            Console.WriteLine("\nIl faut :");

            // Décomposition des billets
            for (int i = 0; i < billets.Length; i++)
            {
                int billet = billets[i];
                int nombreBillets = (int)(somme1 / billet);

                if (nombreBillets > 0)
                {
                    string billetPluriel = (nombreBillets > 1) ? "s" : "";
                    Console.WriteLine("\t" + nombreBillets + " billet" + billetPluriel + "\tde " + billet + " Frs");
                    somme1 %= (uint)billet;
                }
            }

            // Décomposition des pièces
            for (int j = 0; j < pieces.Length; j++)
            {
                int piece = pieces[j];
                int nombrePieces = (int)(somme1 / piece);

                if (nombrePieces > 0)
                {
                    string piecePluriel = (nombrePieces > 1) ? "s" : "";
                    Console.WriteLine("\t" + nombrePieces + " piece" + piecePluriel + "\tde " + piece + " Frs");
                    somme1 %= (uint)piece;
                }
            }
        }
    }
}
