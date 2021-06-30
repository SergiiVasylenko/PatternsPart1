using System;

namespace PatternsPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            IAccount account = new Account();
            Calculator.CalculateInterest(account);

            Console.ReadKey();
        }
    }
}
