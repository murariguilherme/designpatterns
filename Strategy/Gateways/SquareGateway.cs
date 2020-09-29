using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Gateways
{
    public class SquareGateway : IPaymentGateway
    {
        public string GetPaymentGatewayName()
        {
            return "Square";
        }        

        public void Pay(double amount)
        {
            Console.WriteLine($"Payment of ${amount} on {this.GetPaymentGatewayName()} done.");
        }    
    }
}
