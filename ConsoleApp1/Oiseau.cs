using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    class Oiseau : IVolant
    {
        public int NombrePropulseures { get; set; }

        public void Voler()
        {
            Console.WriteLine("Je vole avec " + NombrePropulseures + " ailles");
        }
    }
}
