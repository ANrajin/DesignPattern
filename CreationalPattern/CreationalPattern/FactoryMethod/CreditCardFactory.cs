using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.FactoryMethod
{
    public abstract class CreditCardFactory
    {
        protected abstract ICreditCard Make();
        public ICreditCard Create()
        {
            return this.Make();
        }
    }
}
