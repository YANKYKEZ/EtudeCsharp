using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    class Maths
    {
        // a effacer
        public static int count = 0;
     
        // a effacer 
        public static string connectionString { get; set; } //null


        //A effacer
        public Maths(string ConnectionString)
        {
            connectionString = ConnectionString; //" chaine de connexion ajustée ";
        }

        // a effacer 
        public Maths()
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new Exception("la chaine de connexion est vide");
            }
            count++;
            int test = 0;
            test++; //1
            int t1 = test++; // t1 = 1 avec test=2
            int t2 = ++test; // t2 = 3  avec test=3
            Console.WriteLine("t1 :" + t1);
            Console.WriteLine("t2 :" + t2);
        }

        public static int Addition(int a, int b)
        {
            int resul = a + b;
            Console.WriteLine("le resultat est: " + resul);
            return resul;
        }

        public double Addition(double a=6, double b=2)
        {
            double resul = a + b;
            Console.WriteLine("le resultat est: " + resul);
            return resul;
        }

        public int AdditionChien(Chien c1, Chien c2)
        {
            int resultat = c1.NombrePattes + c2.NombrePattes;
            return resultat;
        }

        public int AdditionChien(Chien c1)
        {
            int resultat = c1.NombrePattes + c1.NombrePattes;
            return resultat;
        }

        public static  double Addtion(double a = 6, double b = 2)
        {
            double resul = a + b;
            Console.WriteLine("le resultat est: " + resul);
            return resul;
        }
    }
}
