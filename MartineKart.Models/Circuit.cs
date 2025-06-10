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
        // Attributs
       public int _distance;
       public bool _rain;

       // Propriétés
       public int Distance { get; set; }
       public bool Rain { get; set; }

        //création d'un circuit
        public void CreaCircuit ()
        {
            Circuit circuit = new Circuit();
            IsRain();
        }

        #region Méthode Pluie
        public void IsRain()
        {
            Random rnd = new Random();
            int rain = rnd.Next(1);
            if (rain == 0)
            {
                _rain = true;
                Console.WriteLine("           ===== ANNONCE METEO =====");
                Console.WriteLine("Il semblerait que nous auront de la pluie aujourd'hui!");
            }
            else
            {
                _rain = false;
                Console.WriteLine("           ===== ANNONCE METEO =====");
                Console.WriteLine("Le temps sera ensoleillé et sec toute la journée!");
            }
        }
        #endregion
    }
    public class CircuitEn8 : Circuit
    {
        _distance = 30;
            #warning Creation des differents circuits
    }
} 
