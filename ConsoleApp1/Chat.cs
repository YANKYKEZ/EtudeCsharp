using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    class Chat:Animal
    {
        public Chat(string prenomChat):base(prenomChat)
        {
            prenom = prenomChat;
        }

        public void Miauler()
        {
            Console.WriteLine("Miaoup! Miaoup");
        }
    }
}
