using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MartineKart.Models
{
    public class Circuit 
    {
       // Propriétés
       public int NbrTour {  get; set; }
       public double Distance { get; set; }
       public bool Rain { get; set; }

        // Constructeur 
        public Circuit(int NbrTour, double Distance, bool Rain)
        {
            this.NbrTour = NbrTour;
            this.Distance = Distance;
            this.Rain = Rain;
        }

        #region Méthode Description Circuit
        public void DescriptionCircuit()
        {
            Console.WriteLine("\nVoici les caractéristiques du circuit:");
            Console.WriteLine($"Nombre de tour = {NbrTour}");
            Console.WriteLine($"Distance = {Distance}");
           #if DEBUG
            Console.WriteLine($"Pluie = {Rain}");
           #endif
        }
        #endregion

        #region Méthode Pluie
        public void IsRain()
        {
            Random rnd = new Random();
            int rain = rnd.Next(2);
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("\n           ===== ANNONCE METEO =====");
            if (rain == 0)
            {
                Rain = true;
                Console.WriteLine("Attention les As du volant, aujourd'hui on annonce de la pluie!");
            }
            else
            {
                Rain = false;
                Console.WriteLine("Le temps sera ensoleillé et sec toute la journée!");
            }
        }
        #endregion
    }
    
    
} 
