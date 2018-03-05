using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    class Voiture
    {
        public string  Couleur { get; set; }
        public string  Marque { get; set; }
        public int Vitesse { get; set; }

        // redefinition de la methode Equal pour redefinir 
        // la methode Equals est un methode de la classe Object. Elle permet de comparer les objets.
        // pour l'utiliser dans nos classe, il faut la redefinir, dans nos classe en utilisant OVERRIDE, vu que dans la classe OBJECT
        // la methode est deja defini enttant que virtuelle, il ne nous reste qu'a choisir les attribut de comparaison de nos objet et de les associer 
        // a la methode Equals en cours de redefinition. voir la  ligne 20.
        public override bool Equals(object obj)
        {
            Voiture v = obj as Voiture;
            if (v == null)
            {
                return false;
            }
            else
            {
                return Vitesse == v.Vitesse && Couleur == v.Couleur && Marque == v.Marque;
            } 
        }
    }
}
