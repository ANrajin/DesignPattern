using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.Factory
{
    public class CardFactory
    {
        /*
         * In this Factory class, basically we are
         * isolating/abstracting the main logic
         * of creating the card type object based on
         * the input parameter, rather then defining it
         * into the implementation class.
         * 
         * this is reducing the tight coupling
         */
        public static CreditCard GetCard(string cardType)
        {
            if (cardType.ToLower() == "moneyback")
                return new Moneyback();
            else if (cardType.ToLower() == "titanium")
                return new Titanium();
            else if (cardType.ToLower() == "platinum")
                return new Platinum();
            else
                return null;
        }
    }
}
