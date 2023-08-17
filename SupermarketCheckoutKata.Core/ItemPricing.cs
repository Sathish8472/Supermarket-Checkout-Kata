using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketCheckoutKata.Core
{
    public class ItemPricing
    {
        public int UnitPrice { get; }
        public (int Quantity, int SpecialPrice) SpecialOffer { get; }

        public ItemPricing(int unitPrice, (int Quantity, int SpecialPrice) specialOffer)
        {
            UnitPrice = unitPrice;
            SpecialOffer = specialOffer;
        }
    }
}
