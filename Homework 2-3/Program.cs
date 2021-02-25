using System;

namespace Homework_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Это приложение создано для того чтобы узнать, четное ли ваше число.Введите желаемое число ниже -");
            string i = Console.ReadLine();
            int i2;
            int i3 = 2;
            try
            {
                i2 = Convert.ToInt32(i);
                if (i2 % i3 == 0)
                {
                    Console.WriteLine("Ваше число четное");
                }
                else
                {
                    Console.WriteLine("Ваше число Нечетное");
                }

            } catch (Exception e)
            {
                Console.WriteLine("Error - Введите число");
            }
            
        }
    }
}
