using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanqueLib;

Random rand = new();
Compte NouveauCompte = new Compte(rand.Next(100, 1000), "Charles-Étienne Filion");
while (true)
{
    Console.Clear();
    Console.WriteLine(NouveauCompte.Description());
    Console.WriteLine("""


     1 - Modifier détenteur
     2 - Peut déposer
     3 - Peut retirer
     4 - Peut retirer (montant)
     5 - Déposer (montant)
     6 - Retirer (montant)
     7 - Vider
     8 - Geler
     9 - Dégeler
     q - Quitter
     r - Reset

     Votre choix,
    """ + $" {NouveauCompte.Détenteur} ?");

    switch (Console.ReadKey(true).KeyChar)
    {
        case '1':
            string nouveauDétenteur = "Votre Nom" + $" {rand.Next(1, 100)}";
            Console.WriteLine($"\n* Détenteur modifié pour : {nouveauDétenteur}");
            NouveauCompte.SetDétenteur(nouveauDétenteur);
            break;
        case '2':
            break;
        case '3':
            break;
        case '4':
            break;
        case '5':
            break;
        case '6':
            break;
        case '7':
            break;
        case '8':
            bool estGelé2 = NouveauCompte.EstGelé;
            NouveauCompte.Geler();
            if (NouveauCompte.EstGelé != estGelé2)
            {
                Console.WriteLine("\n* Le compte a été gelé");
            }
            else
            {
                Console.WriteLine("\n* Impossible de geler un compte déjà gelé.");
            }
            break;
        case '9':
            break;
        case 'q':
            Environment.Exit(0);
            break;
        case 'r':
            break;
        default:
            Console.WriteLine(" Mauvais choix"); break;
    }
    Console.WriteLine("\n Appuyer sur ENTER pour continuer...");
    Console.ReadLine();
}