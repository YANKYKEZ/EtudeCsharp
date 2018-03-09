using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    class Stadium:IComparable
    {
        public int Nbre { get; set; }
        public string NomStade { get; set; }
        public int Capacite { get; set; }

        public int CompareTo(object obj)
        {
            Stadium std = obj as Stadium;
            if (this.Nbre < std.Nbre)
                return -1;
            else if (this.Nbre > Nbre)
                return 1;
            return 0;
        }
    }
}
