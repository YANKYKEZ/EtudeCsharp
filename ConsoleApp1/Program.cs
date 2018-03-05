using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1

{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            string chaine = a.ToString();
            Console.WriteLine(chaine);
            string dix = chaine;
            string lettres = "abc";
            string chaineMaj = lettres.ToUpper();
            Console.WriteLine(chaineMaj);
            

            Animal animal1 = new Animal("MonAnimalPrincipale");

            animal1.NombrePattes = 4;
            Console.WriteLine(animal1.NombrePattes);
            Chien chien1 = new Chien("labral");
            chien1.Aboyer();
            chien1.Respirer();

            List<Animal> maListeAnimaux = new List<Animal>();
            Chien chien2 = new Chien("Monchien2");
            maListeAnimaux.Add(chien2);
            Chat chat1 = new Chat("Monchat1");
            maListeAnimaux.Add(chat1);
            Animal dingo = new Chien("Dingo");
            Animal indefix = new Chien("Indefix");
            Animal tom = new Chat("tOM");
            Animal felix = new Chat("Felix");

            maListeAnimaux.Add(dingo);
            maListeAnimaux.Add(indefix);
            maListeAnimaux.Add(tom);
            maListeAnimaux.Add(felix);

            foreach (Animal animauxList in maListeAnimaux)
            {
                animauxList.Respirer();
            }

            //ObjetVide objetVide = new ObjetVide();
            //Console.WriteLine(objetVide);

            Chien ch = new Chien("chiiiieeeeeeee");
            ch.Respirer();
            ch.color = "red";


            ChienMuet chienm1 = new ChienMuet("klk");
            chienm1.Aboyer();
            chienm1.Respirer();

            chien2.Manger();

            

 //Polymorphysme : c'est le fait qu'une methode puisse etre ecrite plusieurs fois avec un nombre de paramettre different et 
 // et la mm methode soit de plusieurs types. pour mieux comprendre, consulter la classe Maths et la methode Addition().
            Maths mat = new Maths();
            mat.Addition(12.1, 12.1);

            Chien c1 = new Chien("c1");
            Chien c2 = new Chien("c2");

            //Double reel = 1.2;
            //double ent = (int)reel;
            //Console.WriteLine(ent);

            Chien ch1 = new Chien("ch1");
            Animal ani1 = (Animal)ch1;
            Chat cha1 = new Chat("cha1");

// cast des types
            List<Animal> animalliste = new List<Animal>();
            animalliste.Add(ch1);
            animalliste.Add(cha1);

            foreach(Animal an in animalliste)
            {
                // l'objectif ici est qu'un animal de la liste puisse connaitre s'il est un chien ou un chat avant de pouvoir 
                // choisir quelle methode implementer car un chien ne peux pas miauler et un chat ne peux pas aboyer. vue qu'ils sont 
                //tous les animaux et apartiennent a la liste des animaux, il devient imperatif de cater le type.
                if(an is Chien)
                {
                    Chien chi = (Chien)an;
                    chi.Aboyer();
                }
                if(an is Chat)
                {
                    Chat chatt = (Chat)an;
                    chatt.Miauler();
                }
            }
 // Le caste dynamique se fait en utilisant le mot clé  AS pour ce fait le code de dessus pourra s'ecrire:

            foreach( Animal anim in animalliste)
            {
                Chien chi1 = anim as Chien;
                if (chi1 != null)
                {
                    chi1.Aboyer();
                }

                Chat chaa1 = anim as Chat;
                if(chaa1 != null)
                {
                    chaa1.Miauler();
                }
            }

            // Comparaison des object. redefinition de la methode Equals
            Voiture voitureArno = new Voiture()
            {
                Couleur = "red",
                Marque = "Ferarri",
                Vitesse= 350
            };

            Voiture voitureJospin = new Voiture()
            {
                Couleur = "red",
                Marque = "Ferarri",
                Vitesse = 350
            };

            if (voitureArno.Equals(voitureJospin))
            {
                Console.WriteLine("ces deux objet son equivalant");
            }
            else
            {
                Console.WriteLine("Les deux objects sont diferents");
            }
            
        }
    }
}
