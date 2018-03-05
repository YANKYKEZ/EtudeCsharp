using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    class Maths
    {
        public int Addition(int a, int b)
        {
            int resul = a + b;
            Console.WriteLine("le resultat est: " + resul);
            return resul;
            
        }

        public double Addition(double a, double b)
        {
            double resul = a + b;
            Console.WriteLine("le resultat est: " + resul);
            return resul;
        }

        public int AdditionChien(Chien c1, Chien c2)
        {
            int resultat = c1.NombrePattes + c1.NombrePattes;
            return resultat;
        }
    }
}
