using System;

namespace Homework_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число пользователей");
            int count = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < count; ++i)
            {
                Console.WriteLine("И так, " + (i + 1) + " участника зовут" + GetFullName());
            }
        }

        static (string firstName, string lastName, string patronymic) GetFullName()
        {
            
            Console.WriteLine("Введите ваше имя");
            string firstName = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию");
            string lastName = Console.ReadLine();
            Console.WriteLine("Введите ваше отчество");
            string patronymic = Console.ReadLine();
            return (firstName, lastName, patronymic);
        }
    }
}
