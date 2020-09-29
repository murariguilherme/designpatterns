using Decorator.Domain;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Macaroni Decorator");

            Console.WriteLine("A spaghetti with pepper, and cheese, please.");
            Macaroni spaghetti = new SpaghettiMacaroni();
            spaghetti = new PepperCondiment(spaghetti);
            spaghetti = new CheeseCondiment(spaghetti);
            Console.WriteLine(spaghetti.Description() + ", $" + spaghetti.Coast().ToString("#.##"));

            Console.WriteLine();

            Console.WriteLine("A spaghetti with beef, pepper, and double cheese, please.");
            Macaroni linguine = new LinguineMacaroni();
            linguine = new BeefCondiment(linguine);
            linguine = new CheeseCondiment(linguine);
            linguine = new CheeseCondiment(linguine);
            linguine = new PepperCondiment(linguine);
            Console.WriteLine(linguine.Description() + ", $" + linguine.Coast().ToString("#.##"));
            Console.ReadLine();
        }
    }
}
