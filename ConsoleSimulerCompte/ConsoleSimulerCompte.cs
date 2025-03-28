using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanqueLib;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            NouveauCompte.PeutDéposer();
            Console.Write("\n* Peut déposer? ");
            if(NouveauCompte.PeutDéposer() == false)
            {
                Console.Write("Non\n");
            }
            else
            {
                Console.Write("Oui\n");
            }
            break;
        case '3':
            NouveauCompte.PeutRetirer();
            Console.Write("\n* Peut retirer? ");
            if (NouveauCompte.PeutRetirer() == false)
            {
                Console.Write("Non\n");
            }
            else
            {
                Console.Write("Oui\n");
            }
            break;
        case '4':
            Random random = new Random();
            decimal montant = random.Next(0, 10000);
            montant /= 100;
            Console.Write($"\n* Peut retirer {montant:C}? ");
            if (NouveauCompte.PeutRetirer(montant) == false)
            {
                Console.Write("Non\n");
            }
            else
            {
                Console.Write("Oui\n");
            }
            break;
        case '5':
            Random random2 = new Random();
            decimal montant2 = random2.Next(0, 10000);
            montant2 /= 100;
            if(NouveauCompte.PeutDéposer(montant2) == false)
            {
                Console.WriteLine($"\n* Impossible de déposer {montant2:C}");
            }
            else
            {
                NouveauCompte.Déposer(montant2);
                Console.WriteLine($"\n* Dépot de {montant2:C}");
            }
            break;
        case '6':
            Random random3 = new Random();
            decimal montant3 = random3.Next(0, 10000);
            montant3 /= 100;
            if (NouveauCompte.PeutRetirer(montant3) == false)
            {
                Console.WriteLine($"\n* Impossible de retirer {montant3:C}");
            }
            else
            {
                NouveauCompte.Retirer(montant3);
                Console.WriteLine($"\n* Retrait de {montant3:C}");
            }
            break;
        case '7':
            decimal valeur = NouveauCompte.Vider();
            if(valeur == 0)
            {
                Console.WriteLine("\n* Impossible de vider un compte vide ou gelé.");
            }
            else
            {
                Console.WriteLine($"\n* Retrait complet de {valeur:C}");
            }
            break;
        case '8':
            bool estGelé2 = NouveauCompte.EstGelé;
            NouveauCompte.Geler();
            if (NouveauCompte.EstGelé != estGelé2)
            {
                Console.WriteLine("\n* Le compte a été gelé");
            }
            break;
        case '9':
            estGelé2 = NouveauCompte.EstGelé;
            NouveauCompte.Dégeler();
            if (NouveauCompte.EstGelé != estGelé2)
            {
                Console.WriteLine("\n* Le compte a été dégelé");
            }
            break;
        case 'q':
            Environment.Exit(0);
            break;
        case 'r':
            Console.WriteLine("\n* Un nouveau compte a été créé");
            NouveauCompte = new Compte(rand.Next(100, 1000), "Votre Nom");
            break;
        default:
            Console.WriteLine(" Mauvais choix"); break;
    }
    Console.WriteLine("\n Appuyer sur ENTER pour continuer...");
    Console.ReadLine();
}