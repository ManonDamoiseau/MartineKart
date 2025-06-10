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
            
            // public Circuit(int NbrTour, double Distance, bool Rain)
            //Circuit choisi
            if (choixCircuit == 1)
                {
                    Console.WriteLine("Tu as choisi le CIRCUIT EN 8!");
                //Création circuit    ! pluie aléatoire            
                Circuit circuitEn8 = new Circuit(30, 70, true);
                Console.WriteLine("\nVoici les caractéristiques du circuit:");
                Console.WriteLine($"Nombre de tour = {circuitEn8.NbrTour}");
                Console.WriteLine($"Distance = {circuitEn8.Distance}");
                Console.WriteLine($"Pluie = {circuitEn8.Rain}");
            }
            else if (choixCircuit == 2)
                {
                    Console.WriteLine("Tu as choisi le CIRCUIT POIRE!");
                //Création circuit    ! pluie aléatoire
                Circuit circuitPoire = new Circuit(50, 100, false);
                Console.WriteLine("\nVoici les caractéristiques du circuit:");
                Console.WriteLine($"Nombre de tour = {circuitPoire.NbrTour}");
                Console.WriteLine($"Distance = {circuitPoire.Distance}");
                Console.WriteLine($"Pluie = {circuitPoire.Rain}");
            }
            else
                {
                Console.WriteLine("Tu as choisi le CIRCUIT ARC-EN-CIEL");
                //Création circuit    ! pluie aléatoire
                Circuit circuitArcEnCiel = new Circuit(70, 150, true);
                Console.WriteLine("\nVoici les caractéristiques du circuit:");
                Console.WriteLine($"Nombre de tour = {circuitArcEnCiel.NbrTour}");
                Console.WriteLine($"Distance = {circuitArcEnCiel.Distance}");
                Console.WriteLine($"Pluie = {circuitArcEnCiel.Rain}");
            }
            

            #endregion
        }
    }
}