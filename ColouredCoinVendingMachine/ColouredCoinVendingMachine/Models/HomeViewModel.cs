using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ColouredCoinVendingMachine.Models
{
    public class HomeViewModel
    {
        public IEnumerable<Listing> FeaturedListings { get; set; }

        public HomeViewModel()
        {
            this.FeaturedListings = new List<Listing>();
        }

        public HomeViewModel(IEnumerable<Listing> listings)
        {
            this.FeaturedListings = listings;
        }
    }
}