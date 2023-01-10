using System;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //11 задание
            double res = 1;
            int nn = 1;
            int nk = 4;
            int k = nn;
            int a = ((-1) ^ (k ^ (2) - 2 * k + 3) * k + 1 / (k ^ (2) - 2));

            for (; k <= nk; k++)
            {
                res *= a*a;
            }
            Console.WriteLine(res);
        }
    }
}
