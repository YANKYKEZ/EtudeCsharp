using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    class Avion : IVolantMoteur
    {
        public int NombrePropulseures { get; set; }

        public void DemarerMoteur()
        {
            Console.WriteLine("Je demarre le moteur");
        }

        public void Voler()
        {
            Console.WriteLine("Je vole grace à " +NombrePropulseures+ " moteur qui me propulse");
        }
        
    }
}
