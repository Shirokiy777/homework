using System;

namespace Homework_2_2
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
            Console.WriteLine("Введите номер месяца чтобы узнать его название ниже - ");
            string i = Console.ReadLine();
            int i2;
            try
            {
                i2 = Convert.ToInt32(i);
                if (i2 <= 12 && i2 >= 1)
                {
                    Console.WriteLine("месяц под данным номером - " + (Months)i2);
                }
                else
                {
                    Console.WriteLine("Введите числовое значение в диапазоне от 1-12");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Введите числовое значение в диапазоне от 1-12");
            }

            
        }
    }
}
