using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    // cette classe est la representation de l'heritage des interfaces.
    // un objet qui omplemente cette interface implemente aussi l'interfece dont celle ci herite.
    interface IVolantMoteur:IVolant
    {
        void DemarerMoteur();
    }
}
