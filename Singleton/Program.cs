using Singleton.Logger;
using Singleton.Models;
using System;
using System.Linq;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLog = LogManager.GetInstance();
            firstLog.AddLog(new Log(DateTime.Now, RandomString(25)));

            var secondLog = LogManager.GetInstance();
            var someList = secondLog.GetLogList();

            var thirdLog = LogManager.GetInstance();
            thirdLog.AddLog(new Log(DateTime.Now, RandomString(12)));

            Console.WriteLine("Logged added, please press any key to exit");
            Console.ReadLine();
        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
