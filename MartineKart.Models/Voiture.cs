using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartineKart.Models
{
    internal class Voiture : Vehicule
    {
        public Voiture(string modele, string marque) : base(modele, marque)
        {
            this.Modele = modele;
            this.Marque = marque;
        }
        public void TempsParTour(double distance)
        {

            //1d8+ temps  
        }
    }
}
