using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using MartineKart.Models;

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

            #region CHOIX Circuit
            Console.WriteLine("\n=== Choisi ton circuit ===");
            Console.WriteLine(" 1 = Circuit en 8");
            Console.WriteLine(" 2 = Circuit Poire");
            Console.WriteLine(" 3 = Circuit Arc-En-Ciel");
           int.TryParse(Console.ReadLine(), out int choixCircuit);

            //Sécuriser le choix
            while (choixCircuit != 1 && choixCircuit != 2 && choixCircuit != 3)
                {
                    Console.WriteLine("ERREUR : Tu dois entrer un chiffre correspondant à un circuit");
                    int.TryParse(Console.ReadLine(), out choixCircuit);
                }

            
            //Circuit choisi
            if (choixCircuit == 1)
                {
                    Console.WriteLine("Tu as choisi le CIRCUIT EN 8!");
                //Création circuit    ! pluie aléatoire via IsRain();          
                Circuit circuitEn8 = new Circuit(30, 70, true);
                circuitEn8.IsRain();
                circuitEn8.DescriptionCircuit();
            }
            else if (choixCircuit == 2)
                {
                    Console.WriteLine("Tu as choisi le CIRCUIT POIRE!");
                //Création circuit    ! pluie aléatoire via IsRain();
                Circuit circuitPoire = new Circuit(50, 100, false);
                circuitPoire.IsRain();
                circuitPoire.DescriptionCircuit();
            }
            else
                {
                Console.WriteLine("Tu as choisi le CIRCUIT ARC-EN-CIEL");
                //Création circuit    ! pluie aléatoire via IsRain();
                Circuit circuitArcEnCiel = new Circuit(70, 150, true);
                circuitArcEnCiel.IsRain();
                circuitArcEnCiel.DescriptionCircuit();
            }
            #endregion

            #region CHOIX Vehicule
            Console.WriteLine("\n=== Choisi ton véhicule ===");
            Console.WriteLine(" 1 = Voiture");
            Console.WriteLine(" 2 = Moto");
            int.TryParse(Console.ReadLine(), out int choixVehicule);

            //Sécuriser le choix
            while (choixVehicule != 1 && choixCircuit != 2)
            {
                Console.WriteLine("ERREUR : Tu dois entrer un chiffre correspondant à un véhicule");
                int.TryParse(Console.ReadLine(), out choixVehicule);
            }

            //Vehicule choisi
            if (choixVehicule == 1)
            {
                Console.WriteLine("Tu as choisi une voiture!");
            }
            else
            {
                Console.WriteLine("Tu as choisi une moto!");
            }
            #endregion

            #endregion
        }
    }
}