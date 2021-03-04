using System;

namespace Homework_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            int h = 0;
            int otstup;
            int[,] array = new int[5, 5];
            Console.WriteLine("Заполняем массив");
            for(i = 0; i < array.GetLength(0); i++)
            {
                for(j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = h++;
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Выводим диагональ массива при это заполняя ненужные элементы нулями");
            
            for (i = 0; i < array.GetLength(0); i++)
            {
                for (j = 0; j < array.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write($"{array[i, j]} ");
                    }
                    else
                    {
                        array[i, j] = 0;
                        Console.Write($"{array[i, j]} ");
                    }




                }
                Console.WriteLine();
            }
        }
    }
}
