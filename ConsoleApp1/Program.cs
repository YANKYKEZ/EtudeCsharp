using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1

{
    class  Program
    {
        Program pro = new Program();
        static void Main(string[] args)
        {
            
            int a = 10;
            string chaine = a.ToString();
            Console.WriteLine(chaine);
            string dix = chaine;
            string lettres = "abc";
            string chaineMaj = lettres.ToUpper();
            Console.WriteLine(chaineMaj);
            

            //Animal animal1 = new Animal("MonAnimalPrincipale");

            //-------mise en commentaire car l'objet Animal ne peux plus etre instanceié a cause de son statut devenu abstract.
            //animal1.NombrePattes = 4;
            //Console.WriteLine(animal1.NombrePattes);
            //Chien chien1 = new Chien("labral");
            //chien1.Aboyer();
            //chien1.Respirer();

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
            Maths mathe0 = new Maths(" chaine de connexion ajustée ");
            Maths mathe = new Maths();
            Maths mathe1 = new Maths();
            Maths mathe2 = new Maths();
            Maths mathe3 = new Maths();
            Console.WriteLine("instance count : "+ Maths.count);
            mathe.Addition();




            //Polymorphysme : c'est le fait qu'une methode puisse etre ecrite plusieurs fois avec un nombre de paramettre different et 
            // et la mm methode soit de plusieurs types. pour mieux comprendre, consulter la classe Maths et la methode Addition().
            Maths mat = new Maths();
            mat.Addition(12.1, 12.1);

            Chien c1 = new Chien("c1");
            Chien.ConnectChien = c1;

            Chien c2 = new Chien("c2");
            //a effacer
            Console.WriteLine("chaine de connexion  pour chien 1 : " + c1.addChien());

            Console.WriteLine("chaine de connexion  pour chien 2 : " + c2.addChien());

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
            //a effacer 
            Console.WriteLine("notre chien connecte est : " +cha1.Nomduchien());

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

            Femme femme1 = new Femme
            {
                Nom= "F1",
                Taille = 1.76,
                Age= 20
            };
            Femme femme2 = new Femme
            {
                Nom = "F1",
                Taille = 1.70,
                Age = 19,
            };

            if (femme1.Equals(femme2))
            {
                Console.WriteLine("Vous etes un poligame");
            }
            else
            {
                Console.WriteLine("Vous etes monogamme merci de ne pas faire souffrir les fille des gens.");
            }


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

            Chien chienAr = new Chien("Boboul")
            {
                age = 2,
                NombrePattes=4
            };

            Chien chienOt = new Chien("Boul")
            {
                age = 3,
                NombrePattes = 2
            };

            if (chienAr.Equals(chienOt))
            {
                Console.WriteLine("Les deux chiens sont identiques");
            }
            else
            {
                Console.WriteLine("les deux chiens sont diferents");
            }

            //Heures heure1 = new Heures()
            //{
            //    Hr=12,
            //    Min=00,
            //    Second=00
            //};

            //Heures heure2 = new Heures()
            //{
            //    Hr = 01,
            //    Min = 00,
            //    Second = 00
            //};

            //if (heure1.Equals(heure2))
            //{
            //    Console.WriteLine("heure 1 et heure 2  sont  les memes");
            //}
            //Console.WriteLine("ses heures ne sont les memes");

            //if (DateTime.Now.Hour <= 12)
            //{
            //    Console.WriteLine("happy birday");
            //}

            // if(DateTime.Now.DayOfWeek)

           


            // Les interfaces

            Femme[] femm = new Femme[]
            {
                new Femme {Age = 20},new Femme {Age = 29},new Femme {Age = 17},new Femme {Age = 19},new Femme {Age = 21}
            };
            Array.Sort(femm);

            foreach(Femme fe in femm)
            {
                Console.WriteLine(fe.Age );
            }


            Stadium[] std = new Stadium[]
            {
                new Stadium{Nbre=250000},new Stadium{Nbre=300000},new Stadium{Nbre=20000},new Stadium{Nbre=750000},new Stadium{Nbre=30000},new Stadium{Nbre=60000}
            };
            Array.Sort(std);
            foreach (Stadium stdm in std)
            {
                Console.WriteLine(stdm.Nbre);
            }

            // creation de nos propres interfaces.

            Oiseau oiseau = new Oiseau()
            {
                NombrePropulseures = 2
            };
            Avion avion = new Avion()
            {
                NombrePropulseures = 4
            };

            List<IVolant> ivolant = new List<IVolant> { avion, oiseau };
            foreach(IVolant ivol in ivolant)
            {
                //Console.WriteLine(ivol.NombrePropulseures);
                ivol.Voler();
            }

            Moto moto1 = new Moto { NombreMoteur = 1,couleurMoto="Noire",marque="bmw" };
            Tram tram1 = new Tram { NombreMoteur = 6, NomPilote="Arno" };
            List<IRouler> EngentRoulant = new List<IRouler> { moto1, tram1 };

            foreach( IRouler roul in EngentRoulant)
            {
                roul.Rouler();
                Tram tr = roul as Tram;
                if (tr != null)
                    Console.WriteLine(tr.NomPilote);

                Moto mot = roul as Moto;
                if (mot != null)
                    Console.WriteLine(mot.marque + " "+mot.couleurMoto);
                //Console.WriteLine(roul.NombreMoteur);
            }

            // Types anonymes.
            var MaPersonne = new { age = 95, nom = "Arno", profession = "Informaticien" };
            Console.WriteLine(MaPersonne.GetType());
            Console.WriteLine(MaPersonne.age);
             int ProlongeAge()
            {
                
                return  MaPersonne.age + 3;
            }
            Console.WriteLine("jai " + ProlongeAge());

            //Console.ReadLine();
        }
    }
}
