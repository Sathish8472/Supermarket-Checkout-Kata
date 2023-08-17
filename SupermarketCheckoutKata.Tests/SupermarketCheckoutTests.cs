using SupermarketCheckoutKata.Core;

namespace SupermarketCheckoutKata.Tests
{
    [TestFixture]
    public class SupermarketCheckoutTests
    {
        [Test]
        public void TestCalculateTotalPrice()
        {
            var pricingRules = new Dictionary<char, ItemPricing>
            {
                { 'A', new ItemPricing(50, (3, 130)) },
                { 'B', new ItemPricing(30, (2, 45)) },
                { 'C', new ItemPricing(20, (1, 20)) },
                { 'D', new ItemPricing(15, (1, 15)) }
            };

            var checkout = new SupermarketCheckout(pricingRules);

            Assert.AreEqual(130, checkout.CalculateTotalPrice("AAA"));
            Assert.AreEqual(45, checkout.CalculateTotalPrice("BB"));
            Assert.AreEqual(20, checkout.CalculateTotalPrice("C"));
            Assert.AreEqual(15, checkout.CalculateTotalPrice("D"));
            Assert.AreEqual(95, checkout.CalculateTotalPrice("BAB"));
            Assert.AreEqual(205, checkout.CalculateTotalPrice("AAABBB"));
        }
    }
}
