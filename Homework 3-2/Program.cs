using System;

namespace Homework_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const string Chars = "АБВГДЕЖЗИКЛМНОПРСТУХЦШЩЮЭЯ";
            int i;
            int j;
            Random rnd = new Random();
            long number;
            long[,] array = new long[5, 2];
            Console.WriteLine("   НОМЕР    ИНИЦИАЛЫ");
            for (i = 0; i < array.GetLength(0); i++)
            {
                array[i, 0] = number = rnd.Next(000000000, 999999999);
                Console.Write($"+79{array[i, 0]} ");
                for (j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(Chars[rnd.Next(0, Chars.Length)] + ".");

                }
                Console.WriteLine();
            }
        }
    }
}
