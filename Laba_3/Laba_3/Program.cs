using System;

namespace Laba_11
{
    class Task
    { 
        public static bool task(int i)
        {
            if ((i / 1000 == i % 10) && ((i / 100) % 10 == (i % 100) / 10))
            {
                Console.WriteLine("true");
                return true;
            }
            else
            {
                Console.WriteLine("false");
                return false;
            }
        }
    }
    class Program
    {
        // 11. Перевірити істинність вислову:
        // "Дане чотиризначне число читається однаково зліва направо і справа наліво"
        static void Main(string[] args)
        {
            Task.task(4224);
        }
    }
}
