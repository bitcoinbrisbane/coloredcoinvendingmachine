using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ColouredCoinVendingMachine
{
    public class Factory
    {
        public static Clients.IAddressClient GetAddressClient(String type)
        {
            switch (type.Trim().ToLower())
            {
                case "colu":
                    String node = System.Configuration.ConfigurationManager.AppSettings["ColuNode"];
                    return new Clients.ColuWrapper(node);
            }

            throw new ArgumentOutOfRangeException();
        }
    }
}