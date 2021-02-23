using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What's ur name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name} ! Cегодня {DateTime.Now} ");
        }
    }
}
