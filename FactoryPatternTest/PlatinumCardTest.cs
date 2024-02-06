using FactoryPattern;

namespace FactoryPatternTest
{
    [TestClass]
    public class PlatinumCardTest
    {
        [TestMethod]
        public void TestCardType()
        {
            string expectedType = "Platinum Plus";

            CreditCard card = new Platinum();
            Assert.AreEqual(expectedType, card.GetCardType());
        }

        [TestMethod]
        public void TestAnnualCharge()
        {
            int expectedCharge = 2000;

            CreditCard card = new Platinum();
            Assert.AreEqual(expectedCharge, card.GetAnnualCharge());
        }

        [TestMethod]
        public void TestCardLimit()
        {
            int expectedLimit = 35000;

            CreditCard card = new Platinum();
            Assert.AreEqual(expectedLimit, card.GetCreditLimit());
        }
    }
}