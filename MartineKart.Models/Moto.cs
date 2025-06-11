using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartineKart.Models
{
    public class Moto : Vehicule
    {
        public Moto(string modele, string marque) : base(modele, marque)
        {
            this.Modele = modele;
            this.Marque = marque;

        }
        public void TempsParTour(double distance)
        {

            //1d6 + temps  
            //1d3 si pluie
        }
    }
}
