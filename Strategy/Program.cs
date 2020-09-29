using Strategy.Gateways;
using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            IPaymentGateway paymentGateway;                        
            double amount;
            while (true)
            {
                Console.Write("Put the amount to pay: $");
                if (Double.TryParse(Console.ReadLine(), out amount)) break;
            }
           
            while (true)
            {
                Console.WriteLine("Choose a gatewawy option from the following list:");
                Console.WriteLine("\t1 - Paypal");
                Console.WriteLine("\t2 - Square");
                Console.WriteLine("\t3 - Strip");
                Console.WriteLine("\t4 - Fastest (Debit)");                

                int paymentOption;

                while (true)
                {
                    Console.Write("Your option? ");
                    if ((int.TryParse(Console.ReadLine(), out paymentOption)) && (paymentOption >= 1 && paymentOption <=4)) break;
                }
                
                switch (paymentOption)
                {
                    case 1:
                        paymentGateway = new PaypalGateway();
                        break;
                    case 2:
                        paymentGateway = new SquareGateway();
                        break;
                    case 3:
                        paymentGateway = new StripeGateway();
                        break;
                    case 4:
                        paymentGateway = new FastestGateway();
                        break;
                    default:
                        paymentGateway = new PaypalGateway();
                        break;
                }                
                var paymentStrategy = new PaymentStrategy(paymentGateway);
                int finalOption;

                Console.WriteLine("Choose an option from the following list:");
                Console.WriteLine($"\t1 - Pay now using {paymentGateway.GetPaymentGatewayName()}.");
                Console.WriteLine($"\t2 - Back to gateway options.");
                while (true)
                {
                    Console.Write("Your option? ");                    
                    if ((int.TryParse(Console.ReadLine(), out finalOption)) && (finalOption >= 1 && finalOption <= 2)) break;
                }

                if (finalOption == 2) continue;

                paymentStrategy.MakePayment(amount);
                break;
            }                     
        }
    }
}
