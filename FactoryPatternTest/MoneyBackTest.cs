using FactoryPattern;

namespace FactoryPatternTest
{
    [TestClass]
    public class MoneyBackTest
    {
        [TestMethod]
        public void TestCardType()
        {
            string expectedType = "MoneyBack";

            CreditCard card = new MoneyBack();
            Assert.AreEqual(expectedType, card.GetCardType());
        }

        [TestMethod]
        public void TestAnnualCharge()
        {
            int expectedCharge = 500;

            CreditCard card = new MoneyBack();
            Assert.AreEqual(expectedCharge, card.GetAnnualCharge());
        }

        [TestMethod]
        public void TestCardLimit()
        {
            int expectedLimit = 15000;

            CreditCard card = new MoneyBack();
            Assert.AreEqual(expectedLimit, card.GetCreditLimit());
        }

    }
}