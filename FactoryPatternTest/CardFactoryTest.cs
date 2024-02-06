using FactoryPattern;

namespace FactoryPatternTest
{
    [TestClass]
    public class CardFactoryTest
    {
        [TestMethod]
        public void TestGetCreditCard()
        {
            string expectedType = "Titanium Edge";

            CreditCard card = CreditCardFactory.GetCreditCard("Titanium");
            Assert.IsNotNull(card);
            Assert.AreEqual(expectedType, card.GetCardType());
        }
    }
}