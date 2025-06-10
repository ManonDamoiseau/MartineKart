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
            IsRain();
        }

        #region Méthode Pluie
        public void IsRain()
        {
            Random rnd = new Random();
            int rain = rnd.Next(2);
            if (rain == 0)
            {
                Rain = true;
                Console.WriteLine("\n           ===== ANNONCE METEO =====");
                Console.WriteLine("Il semblerait que nous auront de la pluie aujourd'hui!");
            }
            else
            {
                Rain = false;
                Console.WriteLine("\n           ===== ANNONCE METEO =====");
                Console.WriteLine("Le temps sera ensoleillé et sec toute la journée!");
            }
        }
        #endregion
    }
    
    
} 
