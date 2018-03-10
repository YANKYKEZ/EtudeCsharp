using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    class Tram : IRouler
    {
        public int NombreMoteur { get ; set ; }
        public string NomPilote { get; set; }

        public void Rouler()
        {
            Console.WriteLine("Je roule sur les railles, et je suis propulsé par " + NombreMoteur + " leconducteur est " + NomPilote);
           
        }
    }
}
