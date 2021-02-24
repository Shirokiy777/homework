using System;

namespace Homework_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальную температуру за сегодня");
            string tempMin = Console.ReadLine();

            int i;
            try
            {
                i = Convert.ToInt32(tempMin);
            }
            catch (Exception e)
            {
                i = -999;
                Console.WriteLine("Введите числовое значение!");
            }

            Console.WriteLine("Введите Максимальную температуру за сегодня");
            string tempMax = Console.ReadLine();

            int i2;
            try
            {
                i2 = Convert.ToInt32(tempMax);
            } catch (Exception e)
            {
                i2 = -999;
                Console.WriteLine("Введите числовое значение!");
            }
            if (i > i2)
                {
                Console.WriteLine("Как у вас максимальная температура меньше минимальной?");
                }
             else
            {
                Console.WriteLine("Средняя температура за день = " + (i + i2) / 2);
            }
        }
    }
}
