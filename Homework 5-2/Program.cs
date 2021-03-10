using System;
using System.IO;
using System.Text.Json;

namespace Homework_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime data = DateTime.Now;
            string someText = Convert.ToString(data);
            File.WriteAllText($"C:/Users/волк не волк/source/repos/lesson2/startup.txt", someText);
        }
    }
}