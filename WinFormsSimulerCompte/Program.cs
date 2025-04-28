using System;
using System.Text.Json;
using BanqueLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WinFormsSimulerCompte
{
    internal static class Program
    {
        static Random rand = new();
        static decimal montant2 = rand.Next(0, 10000);
        static decimal montant = montant2 / 100;
        private const string JsonFile = "charles_filion.json";
        private static Compte modele = new Compte(rand.Next(1000, 10000), "Charles-Étienne Filion", montant);

        [STAThread]
        static void Main()
        {
            if (File.Exists(JsonFile))
            {
                modele = JsonSerializer.Deserialize<Compte>(File.ReadAllText(JsonFile))!;
            }
            Application.ApplicationExit += Application_ApplicationExit;
            ApplicationConfiguration.Initialize();
            Application.Run(new FormCompte(modele));
        }
        private static void Application_ApplicationExit(object? sender, EventArgs e)
        {
            File.WriteAllText(JsonFile, JsonSerializer.Serialize(modele));
        }
    }
}