using System;

namespace Laba_C_
{
    public static class ApplianceTester
    {
        public static void RunAllTests()
        {
            Console.WriteLine("=== НАЧАЛО ТЕСТИРОВАНИЯ ===\n");

            TestHomeApplianceCreation();
            TestWashingMachineValidation();
            TestMicrowaveValidation();
            TestPrintInfoPolymorphism();
            TestInputHelper();

            Console.WriteLine("\n=== ТЕСТИРОВАНИЕ ЗАВЕРШЕНО ===");
        }

        private static void TestHomeApplianceCreation()
        {
            Console.WriteLine("Тест 1: Создание HomeAppliance");
            try
            {
                var appliance = new HomeAppliance("TestModel", "TestManu", 100.0, 2020);

                // Проверяем значения
                if (appliance.GetModel() == "TestModel" &&
                    appliance.GetManufacturer() == "TestManu" &&
                    appliance.GetPrice() == 100.0 &&
                    appliance.GetYear() == 2020)
                {
                    Console.WriteLine("УСПЕХ: Объект создан корректно");
                }
                else
                {
                    Console.WriteLine("ОШИБКА: Данные не совпадают");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ОШИБКА: {ex.Message}");
            }
        }

        private static void TestWashingMachineValidation()
        {
            Console.WriteLine("\nТест 2: Валидация WashingMachine");

            // Тест отрицательной capacity
            try
            {
                var wm = new WashingMachine("WM100", "Brand", 500.0, 2023, -5.0, "Front Load", 1200);
                Console.WriteLine("ОШИБКА: Ожидалось исключение для отрицательной capacity");
            }
            catch (ArgumentException ex) when (ex.Message.Contains("Capacity"))
            {
                Console.WriteLine("УСПЕХ: Отрицательная capacity отклонена");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ОШИБКА: Неожиданное исключение: {ex.Message}");
            }

            // Тест корректных данных
            try
            {
                var wm = new WashingMachine("GoodWM", "Brand", 500.0, 2023, 8.0, "Front Load", 1200);
                Console.WriteLine("УСПЕХ: Корректные данные приняты");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ОШИБКА: {ex.Message}");
            }
        }

        private static void TestMicrowaveValidation()
        {
            Console.WriteLine("\nТест 3: Валидация Microwave");

            // Тест нулевой мощности
            try
            {
                var microwave = new Microwave("MW200", "Brand", 200.0, 2022, 0, "Convection", 25);
                Console.WriteLine("ОШИБКА: Ожидалось исключение для power = 0");
            }
            catch (ArgumentException ex) when (ex.Message.Contains("Power"))
            {
                Console.WriteLine("УСПЕХ: Нулевая мощность отклонена");
            }

            // Тест отрицательного размера
            try
            {
                var microwave = new Microwave("MW200", "Brand", 200.0, 2022, 800, "Convection", -10);
                Console.WriteLine("ОШИБКА: Ожидалось исключение для отрицательного размера");
            }
            catch (ArgumentException ex) when (ex.Message.Contains("Turntable"))
            {
                Console.WriteLine("УСПЕХ: Отрицательный размер отклонен");
            }
        }

        private static void TestPrintInfoPolymorphism()
        {
            Console.WriteLine("\nТест 4: Полиморфизм PrintInfo()");

            try
            {
                HomeAppliance[] appliances = {
                    new HomeAppliance("Basic", "Manufacturer", 150.0, 2020),
                    new WashingMachine("WM500", "Samsung", 450.0, 2023, 7.5, "Front Load", 1400),
                    new Microwave("MW300", "LG", 220.0, 2022, 900.0, "Convection", 30)
                };

                Console.WriteLine("Вывод информации для разных типов:");
                foreach (var appliance in appliances)
                {
                    Console.WriteLine($"--- {appliance.GetType().Name} ---");
                    appliance.PrintInfo();
                }

                Console.WriteLine("УСПЕХ: Полиморфизм работает корректно");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ОШИБКА: {ex.Message}");
            }
        }

        private static void TestInputHelper()
        {
            Console.WriteLine("\nТест 5: Валидация года в InputHelper");
            Console.WriteLine("(Этот тест требует ручного ввода)");
            Console.WriteLine("Попробуйте ввести неверный год (например, 1979 или 2025)");

            try
            {
                int year = InputHelper.InputYear("Введите год для теста: ");
                Console.WriteLine($"УСПЕХ: Корректный год принят: {year}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ОШИБКА: {ex.Message}");
            }
        }
    }
}
