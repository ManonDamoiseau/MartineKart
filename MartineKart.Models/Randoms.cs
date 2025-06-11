using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartineKart.Models
{
    public interface iRandoms
    {
        public void Dice1d8() // voiture malus
        {
            Random rnd = new Random();
            int dice1d8 = rnd.Next(1, 9);
           
            if (dice1d8 == 1)
            {
                Console.WriteLine("Oh non, il est nécessaire de faire un arrêt pour changer les pneus," 
                    + "tu as pris du retard sur ton temps de course");
                //TempsTotal += 2; // finir le malus
                #warning 
            }
        }
        public void Dice1d6() // moto malus
        {
            Random rnd = new Random();
            int dice1d8 = rnd.Next(1, 7);
        }
        public void Dice1d3() // moto malus pluie
        {
            Random rnd = new Random();
            int dice1d8 = rnd.Next(1, 4);
        }

    }
    
}
