using System;

namespace Homework_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = Console.ReadLine();
            Console.WriteLine(findSum(str));
        }

        static int findSum(String str)
        {
            String temp = "";
            int sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (char.IsDigit(ch))
                {
                    temp += ch;
                }
                else
                {
                    sum += int.Parse(temp);
                    temp = "0";

                }
            }
            return sum + int.Parse(temp);
        }
    }
}
