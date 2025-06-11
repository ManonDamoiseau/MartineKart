using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartineKart.Models
{
    public abstract class Vehicule
    {
        public string Modele { get; set; }
        public string Marque { get; set; }
        public Timer TempsTotal { get; set; }
        public double VitMin { get; set; }
        public double VitMax { get; set; }
        

        public Vehicule(string modele, string marque)
        {
            this.Modele = modele;
            this.Marque = marque;
            
        }

        // Méthode TempsParTour
        public void TempsParTour(double distance)
        {
            
        }

        //Méthode afficher caractéristiques vehicule
        public void Description()
        {
            Console.WriteLine("Les caractéristiques de ton véhicule:");
            Console.WriteLine($"{Modele}");
            Console.WriteLine($"{Marque}");
        }
    }
}
