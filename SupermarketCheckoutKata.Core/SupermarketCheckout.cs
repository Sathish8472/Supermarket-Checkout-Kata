using System;
using System.Collections.Generic;
using System.Linq;

namespace SupermarketCheckoutKata.Core
{
    public class SupermarketCheckout
    {
        private readonly Dictionary<char, ItemPricing> _pricingRules;

        public SupermarketCheckout(Dictionary<char, ItemPricing> pricingRules)
        {
            _pricingRules = pricingRules;
        }

        public int CalculateTotalPrice(IEnumerable<char> items)
        {
            var itemCounts = CountItemOccurrences(items);
            return CalculateTotal(itemCounts);
        }

        private Dictionary<char, int> CountItemOccurrences(IEnumerable<char> items)
        {
            var itemCounts = new Dictionary<char, int>();

            foreach (var item in items)
            {
                if (!IsValidItem(item))
                {
                    throw new KeyNotFoundException($"Item '{item}' not found in pricing rules.");
                }

                UpdateItemCount(itemCounts, item);
            }

            return itemCounts;
        }

        private bool IsValidItem(char item)
        {
            return _pricingRules.ContainsKey(item);
        }

        private void UpdateItemCount(Dictionary<char, int> itemCounts, char item)
        {
            itemCounts[item] = itemCounts.GetValueOrDefault(item) + 1;
        }

        private int CalculateTotal(Dictionary<char, int> itemCounts)
        {
            int totalPrice = 0;

            foreach (var (item, count) in itemCounts)
            {
                var pricingInfo = _pricingRules[item];
                var unitPrice = pricingInfo.UnitPrice;
                var specialOffer = pricingInfo.SpecialOffer;

                int specialPriceCount = count / specialOffer.Quantity;
                int remainingItems = count % specialOffer.Quantity;

                totalPrice += specialPriceCount * specialOffer.SpecialPrice + remainingItems * unitPrice;
            }

            return totalPrice;
        }

    }
}
