using System;

namespace ConsoleApp5
{

    public class Cash
    {
        void Pay(decimal amount)
        {
            Console.WriteLine($"amount Payment :{Math.Round(amount, 2)}");
        }
    }
}