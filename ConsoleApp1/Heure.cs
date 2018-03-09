using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    class Heures
    {
        public Heures(int hr, int min, int second)
        {
            Hr = hr;
            Min = min;
            Second = second;
        }

        public int Hr { get; set; }
        public int Min { get; set; }
        public int Second { get; set; }

        

        //public override bool Equals(object obj)
        //{
        //    Heures heur = obj as Heures;
        //    if (heur == null)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return Hr == heur.Hr && Min == heur.Min && Second == heur.Second;
        //    }
        //}
    }
}
