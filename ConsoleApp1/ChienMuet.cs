using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    class ChienMuet: Chien
    {
        
        public ChienMuet(string prenomChienMuet): base(prenomChienMuet)
        {

        }

        public override void Aboyer()
        {
            Console.WriteLine("Je ne peux aboyer car je suis muet.");
        }


    }
}
