using System;

namespace Homework_4_3
{
    class Program
    {
        public enum Months
        {
            January = 1,
            Feburary,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December,

        }

        static void Main(string[] args)
        {
            int repeat = 1;
            while(repeat == 1)
            {
                WhatMonths();
                Console.WriteLine("Если хотите продолжить, введите 1. Если хотите закончить, закройте программу");
                repeat = Convert.ToInt32(Console.ReadLine());
            }   


            


        }
        static int WhatMonths()
        {
            Console.WriteLine("Введите номер месяца чтобы узнать его название ниже - ");
            int i = Convert.ToInt32(Console.ReadLine());
            int i2 = Convert.ToInt32(i);
            if (i2 <= 12 && i2 >= 1)
            {
                Console.WriteLine("месяц под данным номером - " + (Months)i2);
                if (i2 < 3 || i2 >= 12)
                {
                    Console.WriteLine("Время года - Зима");
                }
                else if (i2 >= 3 || i2 <= 5)
                {
                    Console.WriteLine("Время года - Весна");
                }
                else if (i2 >= 6 || i2 <= 8)
                {
                    Console.WriteLine("Время года - Лето");
                }
                else if (i2 >= 9 || i2 <= 11)
                {
                    Console.WriteLine("Время года - Осень");
                }

            }

                else
                {
                    Console.WriteLine("Введите числовое значение в диапазоне от 1-12");
                }


            return (i);
        }


    }
}
