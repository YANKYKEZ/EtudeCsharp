using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    class Chat:Animal
    {
        //utiliser le chien connecté 
        public string Nomduchien()
        {
            string nomduchien = Chien.ConnectChien==null?"aucun chien connecté ": Chien.ConnectChien.prenom;
            //simil
          /*  string nomduchien = null;
            if(Chien.ConnectChien == null)
                nomduchien = "aucun chien connecté ";
            else
                nomduchien = Chien.ConnectChien.prenom;
            */
            return nomduchien;
        }
        public Chat(string prenomChat):base(prenomChat)
        {
            prenom = prenomChat;
        }

        public void Miauler()
        {
            Console.WriteLine("Miaoup! Miaoup");
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
