using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.FactoryMethod
{
    public class TitaniumFactory : CreditCardFactory
    {
        protected override ICreditCard Make()
        {
            return new Titanium();
        }
    }
}
