using System;

namespace Homework_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int datey = DateTime.Now.Year;
            int price = 2112;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" _____________________________________");
            Console.WriteLine("| АВТОБУС                       ОБЩИЙ |");
            Console.WriteLine("| 426039 ИЖЕВСК                       |");
            Console.WriteLine("| ОАО ИПОПАТ                          |");
            Console.WriteLine("| АП2                                 |");
            Console.WriteLine("| ИИН 1833046700        КПП 183301001 |");
            Console.WriteLine("|                                     |");
            Console.WriteLine("| ВСКАЯ, Д.#5                         |");
            Console.WriteLine("|                                     |");
            Console.WriteLine("| БИЛЕТ                        ПРОЕЗД |");
            Console.WriteLine("| МЕСТ БАГАЖА                      00 |");
            Console.WriteLine("| СУММА(КОД): " + price + "                    | ");
            Console.WriteLine("|                 " + datey + "                |");
            Console.WriteLine("|_____________________________________|");
             

        }
    }
}
