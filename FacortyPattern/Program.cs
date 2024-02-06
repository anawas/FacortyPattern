using System;

namespace FactoryPattern {
    class Program {
        static void Main(string[] args)
        {
            string cardType = "MoneyBack";
            CreditCard card = null;

            switch (cardType)
            {
                case "MoneyBack":
                    card = new MoneyBack();
                    break;
                case "Titanium":
                    card = new Titanium();
                    break;
                case "Platinum":
                    card = new Platinum();
                    break;
            }

            if (card != null)
            {
                Console.WriteLine("Card type    : " + card.GetCardType());
                Console.WriteLine("Credit limit : " + card.GetCreditLimit());
                Console.WriteLine("Annual charge: " + card.GetAnnualCharge());
            }
            else
            {
                Console.WriteLine("Invalid card type.");
            }
        }
    }
}