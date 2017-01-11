using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ColouredCoinVendingMachine.Models
{
    public class OrderViewModel
    {
        public String AssetId { get; set; }

        public Decimal Quantity { get; set; }

        public String DeliveryAddress { get; set; }

        public String PaymentAddress { get; set; }
    }
}