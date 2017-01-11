using System;
using System.Threading.Tasks;

namespace ColouredCoinVendingMachine.Clients
{
    public interface IAddressClient
    {
        Task<String> GetAddressAsync();
    }
}
