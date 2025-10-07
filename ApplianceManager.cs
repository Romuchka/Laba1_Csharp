using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_C_
{
    public class ApplianceManager
    {
        private List<HomeAppliance> appliances = new List<HomeAppliance>();

        public void CreateAndAddAppliance()
        {
            Console.WriteLine("Choose appliance type to add:");
            Console.WriteLine("1. HomeAppliance");
            Console.WriteLine("2. WashingMachine");
            Console.WriteLine("3. Microwave");

            int choice = InputHelper.InputInteger("Enter choice: ");

            Console.Write("Enter model: ");
            string model = Console.ReadLine();

            Console.Write("Enter manufacturer: ");
            string manufacturer = Console.ReadLine();

            double price = InputHelper.InputPositiveDouble("Enter price: ");
            int year = InputHelper.InputYear("Enter year: ");

            try
            {
                switch (choice)
                {
                    case 1:
                        appliances.Add(new HomeAppliance(model, manufacturer, price, year));
                        Console.WriteLine("HomeAppliance успешно добавлен!");
                        break;

                    case 2:
                        double capacity = InputHelper.InputPositiveDouble("Enter capacity: ");

                        Console.Write("Enter wash type: ");
                        string washType = Console.ReadLine();

                        int spinSpeed = InputHelper.InputPositiveInteger("Enter spin speed: ");

                        appliances.Add(new WashingMachine(model, manufacturer, price, year, capacity, washType, spinSpeed));
                        Console.WriteLine("WashingMachine успешно добавлен!");
                        break;

                    case 3:
                        double power = InputHelper.InputPositiveDouble("Enter power: ");

                        Console.Write("Enter cooking type: ");
                        string cookingType = Console.ReadLine();

                        int turntableSize = InputHelper.InputPositiveInteger("Enter turntable size: ");

                        appliances.Add(new Microwave(model, manufacturer, price, year, power, cookingType, turntableSize));
                        Console.WriteLine("Microwave успешно добавлен!");
                        break;

                    default:
                        Console.WriteLine("Неверный выбор.");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Произошла ошибка: {e.Message}");
            }
        }

        public void PrintAllAppliances()
        {
            if (appliances.Count == 0)
            {
                Console.WriteLine("No appliances in the list.");
                return;
            }

            for (int i = 0; i < appliances.Count; i++)
            {
                Console.WriteLine($"Appliance #{i + 1}:");
                appliances[i].PrintInfo();
                Console.WriteLine("------------------------");
            }
        }

        public void Run()
        {
            bool done = false;
            while (!done)
            {
                Console.WriteLine("\n=== Appliance Management System ===");
                Console.WriteLine("1. Add appliance");
                Console.WriteLine("2. Print all appliances");
                Console.WriteLine("3. Exit");

                int choice = InputHelper.InputInteger("Enter choice: ");

                switch (choice)
                {
                    case 1:
                        CreateAndAddAppliance();
                        break;
                    case 2:
                        PrintAllAppliances();
                        break;
                    case 3:
                        done = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Пожалуйста, попробуйте снова.");
                        break;
                }
            }
        }
    }
}
