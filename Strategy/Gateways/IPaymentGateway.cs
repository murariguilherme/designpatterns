using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Gateways
{
    public interface IPaymentGateway
    {
        void Pay(double amount);
        string GetPaymentGatewayName();
    }
}
