using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ColouredCoinVendingMachine.Clients
{
    public class OpenAsset : IAddressClient
    {
        public string GetAddress()
        {
            throw new NotImplementedException();
        }

        public async Task<string> GetAddressAsync()
        {
            throw new NotImplementedException();
        }
    }
}