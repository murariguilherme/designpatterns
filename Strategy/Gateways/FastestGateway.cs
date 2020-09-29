using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Gateways
{
    public class FastestGateway: IPaymentGateway
    {
        public string GetPaymentGatewayName()
        {
            return "Fastest";
        }

        public bool HasAccountBalance(double amount)
        {
            var random = new Random();
            var result = random.Next(1, 3);
            return result == 1;
        }

        public void Pay(double amount)
        {
            if (!HasAccountBalance(amount))
            {
                Console.WriteLine($"You don't have balance to make this payment in your {GetPaymentGatewayName()} account.");
                return;
            }            
            Console.WriteLine($"Payment of ${amount} on {this.GetPaymentGatewayName()} done.");
        }
    }
}
