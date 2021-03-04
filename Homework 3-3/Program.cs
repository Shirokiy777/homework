using System;

namespace Homework_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string greet = "Hello";
            char[] kek = greet.ToCharArray();

            int i;
            for (i = kek.Length; i > 0; i--)
            {
                Console.Write(kek[i - 1]);
            }
        }
    }
}
