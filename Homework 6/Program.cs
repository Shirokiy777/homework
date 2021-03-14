using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Homework_6
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            GetProcessList();
            Console.WriteLine("Для завершения процесса по NAME, нажмите 1.");
            Console.WriteLine("Для завершения процесса по ID, нажмите 2.");
            string choose = Console.ReadLine();
            int choose2 = Convert.ToInt32(choose);
            if (choose2 == 1)
            {
                KillProcessByName();
            } else if (choose2 == 2)
            {
                KillProcessByID();
            }




        }

        public static void GetProcessList()
        {
            Console.WriteLine("СПИСОК ЗАПУЩЕННЫХ ПРОЦЕССОВ");
            foreach(Process process in Process.GetProcesses())
            {
                Console.WriteLine($"ID: {process.Id}  Name: {process.ProcessName}");
            } 
        }

        public static void KillProcessByName()
        {
            Console.WriteLine("Введите ID или NAME процесса для его завершения");
            string NameID = Console.ReadLine();
            Process[] processes = Process.GetProcessesByName(NameID);
            foreach (Process process in processes)
            {
                process.Kill();
            }
        }

        public static void KillProcessByID()
        {
            Console.WriteLine("Введите ID или NAME процесса для его завершения");
            string NameID = Console.ReadLine();
            Process processes = Process.GetProcessById(Int32.Parse(NameID));
            processes.Kill();

        }



    }
    
}