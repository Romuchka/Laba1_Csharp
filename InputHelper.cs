using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_C_
{
    public static class InputHelper
    {
        public static int InputInteger(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (int.TryParse(input, out int result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Ошибка: Введите корректное целое число! Попробуйте снова.");
                }
            }
        }

        public static double InputDouble(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (double.TryParse(input, out double result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Ошибка: Введите корректное число! Попробуйте снова.");
                }
            }
        }

        public static int InputYear(string prompt)
        {
            while (true)
            {
                int year = InputInteger(prompt);
                int currentYear = 2023;

                if (year < 1980 || year > currentYear)
                {
                    Console.WriteLine($"Ошибка: Год должен быть между 1980 и {currentYear}. Попробуйте снова.");
                }
                else
                {
                    return year;
                }
            }
        }

        public static double InputPositiveDouble(string prompt)
        {
            while (true)
            {
                double value = InputDouble(prompt);
                if (value > 0) return value;
                Console.WriteLine("Ошибка: Значение должно быть положительным! Попробуйте снова.");
            }
        }

        public static int InputPositiveInteger(string prompt)
        {
            while (true)
            {
                int value = InputInteger(prompt);
                if (value > 0) return value;
                Console.WriteLine("Ошибка: Значение должно быть положительным! Попробуйте снова.");
            }
        }
    }
}
