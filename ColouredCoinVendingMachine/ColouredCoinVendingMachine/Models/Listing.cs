using System;
using System.ComponentModel.DataAnnotations;

namespace ColouredCoinVendingMachine.Models
{
    public class Listing
    {
        [Required]
        public String Name { get; set; }

        [Required, Display(Name = "Address to send assets to")]
        public String AssetAddress { get; set; }

        public String AssetId { get; set; }

        [Required, Display(Name = "Amount of tokens per 1BTC")]
        public Decimal Rate { get; set; }

        [Required, Display(Name = "Your bitcoin address to receive payments")]
        public String PayOutAddress { get; set; }

        public String HDPayOutPubKey { get; set; }

        public String ListingFeeAddress { get; set; }

        public Decimal ListingFee { get; set; }

        [Display(Name = "Asset definition JSON url")]
        public String AssetDefinitionUrl { get; set; }

        [Display(Name = "Project website")]
        public String ProjectUrl { get; set; }

        /// <summary>
        /// HTTP Post to this url on purchase
        /// </summary>
        public String NotificationUrl { get; set; }
    }
}