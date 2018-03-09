using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    class Femme: IComparable
    {
        public string Nom { get; set; }
        public double Taille { get; set; }
        public int Age { get; set; }

        //public override bool Equals(object obj)
        //{
        //    Femme femme = obj as Femme;
        //    if (femme == null)
        //        return false;
        //    else
        //        return Nom == femme.Nom && Taille == femme.Taille && Age == femme.Age; 
        //}

        // les interfaces de comparaison
        public int CompareTo(object obj)
        {
            Femme fem = (Femme)obj;

            return Age.CompareTo(fem.Age);
        }
    }
}
