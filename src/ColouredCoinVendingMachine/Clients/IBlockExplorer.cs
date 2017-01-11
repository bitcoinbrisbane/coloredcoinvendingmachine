using System;

namespace ColouredCoinVendingMachine.Clients
{
    public interface IBlockExplorer
    {
        Int64 GetAddressBalance(String address);
    }
}
