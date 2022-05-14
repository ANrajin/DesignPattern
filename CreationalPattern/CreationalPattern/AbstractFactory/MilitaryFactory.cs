using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.AbstractFactory
{
    //Abstarct Factory
    public abstract class MilitaryFactory
    {
        public abstract Fighter GetFighter();
        public abstract Ship GetShip();
    }
}
