using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    class Chien:Animal
    {
        public string color { get; set; }
        public Chien(string prenomChien):base(prenomChien)
        {
           
        }
        public virtual void Aboyer()
        {
            Console.WriteLine("Waoup ! Waoup!");
        }

        public void Viellir()
        {
            age++;
        }

        public  void Naissance()
        {
            age = 0;
            estVivant = true;
        }

//Redefinition de la methode Manger en y apportant des modification : SUBSTITUTION... Pour le faire, il faut que la classe
// mere utilise le mot clé VIRTUAL(public virtual void Manger()) pour annoncer que cette methode pourra etre redefinit dans  une des classe fille. 
//Dans les classes fille, il imperatif d'utiliser le mot clé OVERRIDE ( public override void Additionner())
// 

        public override void Manger()
        {
            Console.WriteLine("Reclamer le repas a son maitre");
            base.Manger();
            Console.WriteLine("...");
        }

    }
}
