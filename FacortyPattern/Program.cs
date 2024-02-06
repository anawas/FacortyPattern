using System;

namespace FactoryPattern {
    class Program {
        static void Main(string[] args)
        {
            string cardType = "MoneyBack";

            CreditCard card = CreditCardFactory.GetCreditCard(cardType);
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