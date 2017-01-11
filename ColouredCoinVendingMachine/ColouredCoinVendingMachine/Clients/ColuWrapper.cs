using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ColouredCoinVendingMachine.Clients
{
    public class ColuWrapper : IAddressClient
    {
        public String Node { get; set; }

        public ColuWrapper()
        {
        }

        public ColuWrapper(String node)
        {
            this.Node = node;
        }

        public async Task<String> GetAddressAsync()
        {
            using (Colu.Client client = new Colu.Client(Node))
            {
                var response = await client.GetAddressAsync();
                return response.Result;
            }
        }
    }
}