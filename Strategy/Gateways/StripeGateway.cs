using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Gateways
{
    public class StripeGateway: IPaymentGateway
    {
        public string GetPaymentGatewayName()
        {
            return "Stripe";
        }

        public void Pay(double amount)
        {
            Console.WriteLine($"Payment of ${amount} on {this.GetPaymentGatewayName()} done.");
        }
    }
}
