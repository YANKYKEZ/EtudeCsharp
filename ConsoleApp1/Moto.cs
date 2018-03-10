using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    class Moto : IRouler
    {
        public int NombreMoteur { get ; set ; }
        public string couleurMoto { get; set; }
        public string marque { get; set; }

        public void Rouler()
        {
            Console.WriteLine("Je suis un engent de 2 roues j'ai " + NombreMoteur + " moteur qui me permet/tent de rouler");
        }
    }
}
