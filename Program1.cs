using System;

namespace Homework1
{
    class Program
    {
        public class TestCase
        {
            public int d { get; set; }

            public int n { get; set; }

            public int Expected { get; set; }
            public Exception ExpectedException { get; set; }
        }
        static void Testfunc(TestCase testCase)
        {
            try
            {
                var actual = function(testCase.d);

                if (actual == testCase.Expected)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
            catch (Exception ex)
            {
                if (testCase.ExpectedException != null)
                {
                    //TODO add type exception tests;
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
        }

        static void Main(string[] args)
        {
            var testCase1 = new TestCase()
            {
                n = 7,
                Expected = 0,
                ExpectedException = null
            };

            var testCase2 = new TestCase()
            {
                n = 5,
                Expected = 0,
                ExpectedException = null
            };

            Testfunc(testCase1);
            Testfunc(testCase2);
        }
        static int function(int n)
        {

            Console.WriteLine("Введите число для проверки на простоту");
            //n = Convert.ToInt32(Console.ReadLine());
            int d = 0;
            int i = 2;


            while (i <= n)
            {
                if (i < n)
                {
                    if (n % i == 0)
                    {
                        d++;
                        i++;
                    }
                    else
                    {
                        i++;

                    }
                }

                else
                {
                    if (d == 0)
                    {
                        Console.WriteLine("Простое ");

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Не простое");

                        break;
                    }
                }
            }
            return n;



        }

    }
}



