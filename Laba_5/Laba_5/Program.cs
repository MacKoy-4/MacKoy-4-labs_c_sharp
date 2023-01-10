using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_5
{
    class Program
    {

        public static void Main()
        {

            Console.WriteLine("Уведіть розмір матриці NxM");
            int n, m, i, j;
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, m];
            Random ranod = new Random();
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    mat[i, j] =  ranod.Next(0, 10);
                    Console.Write("{0,3}", mat[i, j]);
                }
                Console.WriteLine();
            }
            int sum1 = 0;

            for (i = 1; i < n; i++)// перебираєм стовпці
            {

                for (j = 1; j < m - 1; j++)// перебираєм елементи стовпці
                {
                    if (mat[i, j] == mat[i, j + 1])
                        break;
                }
                if (j == m - 1)
                    sum1 = sum1 + 1;

            }
            int sum2 = 0;
            for (j = 1; j < m; j++)// перебираєм рядки
            {

                for (i = 1; i < n - 1; i++)// перебираєм елементи рядків
                {
                    if (mat[i, j] == mat[i - 1, j])
                        break;
                }
                if (i == n - 1)
                    sum2 = sum2 + 1;

            }
            Console.WriteLine("Кількість стовпців, всі елементи яких різні {0}", sum1);
            Console.WriteLine("Кількість рядків, всі елементи яких різні {0}", sum2);
        }
    }
}