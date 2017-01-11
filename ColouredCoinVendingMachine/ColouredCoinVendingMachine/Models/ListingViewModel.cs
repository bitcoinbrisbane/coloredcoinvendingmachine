using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ColouredCoinVendingMachine.Models
{
    public class ListingViewModel : Listing
    {
        public Int64 AmountForSale { get; set; }
    }
}