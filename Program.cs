using System;

namespace Homework1_2
{
    class Program
    {
        static int fibr(int n) //Через рекурсию
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            return fibr(n - 1) + fibr(n - 2);
        }

        static int fibf(int n) //Через цикл FOR
        {
            int f0 = 0;
            int f1 = 1;
            int sum = 0;
            for (int i = 1; i < n; i++)
                {
                    sum = f0 + f1;
                    f0 = f1;
                    f1 = sum;
                }
            return n switch
            { 
                0 => 0,
                1 => 1,
                _ => sum

            
            };


        }


        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                
                Console.WriteLine(fibr(i));
            }
            Console.WriteLine();
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(fibf(i));
                
            }
        }
    }
}
