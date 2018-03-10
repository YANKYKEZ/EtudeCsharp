using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    public abstract class Animal
    {
        public int NombrePattes { get; set; }
        protected bool estVivant { get; set; }
        public int age { get; set; }
        // protected string prenom { get; set; }

        //a effacer
        public string prenom { get; set; }

        public Animal()
        {
            NombrePattes = 4;
            estVivant = true;
            age = 1;
            prenom = "ChienParDefaut";
             coeur = new Coeur();
        }

        public Animal(string prenomAnimal)
        {
            prenom = prenomAnimal;

        }


        public virtual void Respirer()
        {
            Console.WriteLine("Je m'apelle " + prenom + " Je sais respire");
        }



        public virtual void Manger()
        {
            Console.WriteLine("Mettre la nourrituire dans la bouche,");
            Console.WriteLine("Macher la nourriture");
            Console.WriteLine("Avaler");
        }

        // Methode Abstraite
        public abstract void SeDeplacer();
        private Coeur coeur;

        public void Mourrir()
        {
            coeur.stoppeBattre();
        }
      
        
    }
}
