using FactoryPattern;

namespace FactoryPatternTest
{
    [TestClass]
    public class TitaniumCardTest
    {
        [TestMethod]
        public void TestCardType()
        {
            string expectedType = "Titanium Edge";

            CreditCard card = new Titanium();
            Assert.AreEqual(expectedType, card.GetCardType());
        }

        [TestMethod]
        public void TestAnnualCharge()
        {
            int expectedCharge = 1500;

            CreditCard card = new Titanium();
            Assert.AreEqual(expectedCharge, card.GetAnnualCharge());
        }

        [TestMethod]
        public void TestCardLimit()
        {
            int expectedLimit = 25000;

            CreditCard card = new Titanium();
            Assert.AreEqual(expectedLimit, card.GetCreditLimit());
        }

    }
}