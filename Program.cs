using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите режим:");
            Console.WriteLine("1 - Основная программа");
            Console.WriteLine("2 - Запуск тестов");

            string choice = Console.ReadLine();

            if (choice == "2")
            {
                // Запуск тестов
                ApplianceTester.RunAllTests();
            }
            else
            {
                // Основная программа
                ApplianceManager manager = new ApplianceManager();
                manager.Run();
            }
        }
    }
}
