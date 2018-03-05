using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    class Animal
    {
        public int NombrePattes { get; set; }
        protected bool estVivant { get; set; }
        public int age { get; set; }
        protected string prenom { get; set; }

        public Animal()
        {
            NombrePattes = 4;
            estVivant = true;
            age = 1;
            prenom = "ChienParDefaut";
        }

        public Animal ( string prenomAnimal)
        {
            prenom = prenomAnimal;

        }


        public virtual void Respirer()
        {
            Console.WriteLine("Je m'apelle "+ prenom +" Je sais respire");
        }



        public virtual void Manger()
        {
            Console.WriteLine("Mettre la nourrituire dans la bouche,");
            Console.WriteLine("Macher la nourriture");
            Console.WriteLine("Avaler");
        }
    }
}
