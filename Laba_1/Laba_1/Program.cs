using System;

namespace Laba_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var ts = TimeSpan.FromSeconds(3665);

            Console.WriteLine(" {0} год. {1} хв. {2} сек.", ts.Hours, ts.Minutes, ts.Seconds);
        }
    }
}
