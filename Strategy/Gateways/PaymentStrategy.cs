using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Gateways
{
    public class PaymentStrategy
    {
        private IPaymentGateway _paymentGateway;
        public PaymentStrategy(IPaymentGateway paymentGateway)
        {
            _paymentGateway = paymentGateway;
        }

        public void setPaymentGateway(IPaymentGateway paymentGateway)
        {
            _paymentGateway = paymentGateway;
            Console.WriteLine($"Changing gateway to: {_paymentGateway.GetPaymentGatewayName()}");
        }

        public void MakePayment(double amount)
        {
            _paymentGateway.Pay(amount);            
        }
    }
}
