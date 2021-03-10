using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;



namespace Homework_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите произвольный порядок чисел");
            string someText = Console.ReadLine();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(new FileStream("C:/Users/волк не волк/source/repos/lesson2/Homework 5 3/Sometext.bin",FileMode.OpenOrCreate), someText);
        }
    }
}