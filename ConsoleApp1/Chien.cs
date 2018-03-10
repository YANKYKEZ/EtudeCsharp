using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    class Chien:Animal
    {
        //a effacer chien connecté 
        public static Chien ConnectChien { get; set; }
        //a affacer
        public string addChien()
        {
            string chainedeconnexion = Maths.connectionString;
            //faire les operations ici
            return chainedeconnexion;
        }
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

        public override bool Equals(object obj)
        {
            Chien ch = obj as Chien;
            if (ch == null)
            {
                return false;
            }else

            {
                return ch.NombrePattes == NombrePattes && ch.prenom == prenom && ch.age == age; 
            }
            
        }

        public override int GetHashCode()
        {
            return prenom.GetHashCode() * age.GetHashCode() * NombrePattes.GetHashCode();
        }


        //la redefinition de cette methode est obligatoire car la methode est abstract et la classe chien herite de 
        // animale qui elle mme est abstract. d'ou l'obligation de redefinition.
        public override void SeDeplacer()
        {
            Console.WriteLine("je me deplace");
        }

    }
}
