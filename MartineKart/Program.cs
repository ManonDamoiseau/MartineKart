using System;

namespace MartineKart
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Intro Jeu
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("- - - - - - -  MARTINE KART  - - - - - - - - -");
            Console.WriteLine("----------------------------------------------");

            Console.WriteLine("\n=== Choisi ton circuit ===");
            Console.WriteLine(" 1 = Circuit en 8");
            Console.WriteLine(" 2 = Circuit Poire");
            Console.WriteLine(" 3 = Circuit Arc-En-Ciel");
            int.TryParse(Console.ReadLine(), out int choixCircuit);

            //Sécuriser le choix
            while (choixCircuit != 1 || choixCircuit != 2 || choixCircuit != 3)
                {
                    Console.WriteLine("ERREUR : Tu dois entrer un chiffre correspondant à un circuit");
                }
            //Circuit choisi
            if (choixCircuit == 1)
                {
                    Console.WriteLine("Tu as choisi le CIRCUIT EN 8!");
                    //Appel méthode circuit en 8
#warning WIP méthode
                }
            else if (choixCircuit == 2)
                {
                    Console.WriteLine("Tu as choisi le CIRCUIT POIRE!");
                    //Appel méthode circuit poire
#warning WIP méthode
                }
            else
                {
                Console.WriteLine("Tu as choisi le CIRCUIT ARC-EN-CIEL");
                //Appel méthode circuit arc-en-ciel
#warning WIP méthode
                }


            #endregion
        }
    }
}