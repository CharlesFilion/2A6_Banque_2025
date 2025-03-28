using System.Diagnostics.CodeAnalysis;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BanqueLib
{
    public class Compte
    {
        private int numéro;
        private string détenteur;
        private decimal solde;
        private StatutCompte statut;
        private bool estGelé = false;
        public enum StatutCompte { Ok, Gelé }

        public Compte(int numéro, string détenteur, decimal solde = 0, StatutCompte statut = StatutCompte.Ok)
        {
            if (numéro <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                this.numéro = numéro;
            }
            if(string.IsNullOrEmpty(détenteur))
            {
                throw new ArgumentNullException();
            }
            else if (string.IsNullOrWhiteSpace(détenteur))
            {
                throw new ArgumentException();
            }
            else
            {
                this.détenteur = détenteur;
            }
            if(solde < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else if(Précision(solde) == false)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                this.solde = solde;
            }
            this.statut = statut;

            SetDétenteur(détenteur);
        }

        public int Numéro => numéro;
        public string Détenteur => détenteur;
        public decimal Solde => solde;
        public StatutCompte Statut => statut;
        public bool EstGelé => estGelé;


        [MemberNotNull("détenteur")]
        public void SetDétenteur(string Détenteur)
        {
            if (string.IsNullOrEmpty(Détenteur))
            {
                throw new ArgumentNullException();
            }
            else if (string.IsNullOrWhiteSpace(Détenteur))
            {
                throw new ArgumentException();
            }
            détenteur = Détenteur.Trim();
        }

        public string Description()
        {
            string description = "";
            description += "[CF] * * * * * * * * * * * * * * * * * * * * * * * * *";
            description += $"\n[CF] *      Compte : {numéro}".PadRight(54, ' ') + '*';
            description += $"\n[CF] *          De : {détenteur}".PadRight(54, ' ') + '*';
            description += $"\n[CF] *       Solde : {solde:C}".PadRight(54, ' ') + '*';
            description += $"\n[CF] *      Statut : {statut}".PadRight(54, ' ') + '*';
            description += "\n[CF] * * * * * * * * * * * * * * * * * * * * * * * * *";
            return description;
        }

        public bool Précision(decimal nombre)
        {
            decimal nombreArrondi = decimal.Round(nombre, 2);
            if (nombreArrondi != nombre)
            {
                return false;
            }
            return true;
        }

        public bool PeutRetirer(decimal nombre = 0)
        {
            decimal nombreArrondi = decimal.Round(nombre, 2);
            if (nombreArrondi != nombre)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (nombre > solde || statut == StatutCompte.Gelé || nombre < 0)
            {
                throw new ArgumentOutOfRangeException();
                return false;
            }
            return true;
        }

        public bool PeutDéposer(decimal nombre = 0)
        {
            decimal nombreArrondi = decimal.Round(nombre, 2);
            if (nombreArrondi != nombre)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (statut == StatutCompte.Gelé || nombre < 0)
            {
                return false;
            }
            return true;
        }

        public void Déposer(decimal montant)
        {
            if (PeutDéposer(montant) == false)
            {
                throw new InvalidOperationException();
            }

            else
            {
                solde += montant;
            }
        }

        public void Retirer(decimal montant)
        {
            if (PeutRetirer(montant) == false)
            {
                throw new InvalidOperationException();
            }
            else
            {
                solde -= montant;
            }
        }

        public decimal Vider()
        {
            if(statut == StatutCompte.Gelé || solde == 0)
            {
                throw new InvalidOperationException();
            }
            decimal valeur = solde;
            solde = 0;
            return valeur;
        }

        public void Geler()
        {
            if (statut == StatutCompte.Gelé)
            {
                Console.WriteLine("\n* Impossible de geler un compte déjà gelé.");
            }
            else
            {
                statut = StatutCompte.Gelé;
                estGelé = true;
            }
        }

        public void Dégeler()
        {
            if (statut == StatutCompte.Gelé)
            {
                statut = StatutCompte.Ok;
                estGelé = false;
            }
            else
            {
                Console.WriteLine("\n* Impossible de dégeler un compte non gelé.");
            }
        }
    }
}