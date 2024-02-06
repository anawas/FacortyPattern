using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class CreditCardFactory
    {
        public static CreditCard GetCreditCard(string cardType)
        {

            switch (cardType)
            {
                case "MoneyBack":
                    return new MoneyBack();
                case "Titanium":
                    return new Titanium();
                case "Platinum":
                    return new Platinum();
            }
            return null;
        }
    }
}
