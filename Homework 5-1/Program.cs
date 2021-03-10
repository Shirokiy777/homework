using System;
using System.IO;
using System.Net.Mime;

namespace Homework_5_1
{
    class Program
    {
        static void Main(string[] args)
        {

        string someText = Console.ReadLine();
        File.WriteAllText("C:/Users/волк не волк/source/repos/lesson2/text.txt", someText);
        }
    }
}