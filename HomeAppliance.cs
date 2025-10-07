using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_C_
{
    public class HomeAppliance
    {
        protected string model;
        protected string manufacturer;
        protected double price;
        protected int year;

        public HomeAppliance(string m = "Unknown", string manu = "Unknown", double p = 0.0, int y = 2000)
        {
            model = m;
            manufacturer = manu;
            price = p;
            year = y;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Model: {model}, Manufacturer: {manufacturer}, Price: {price} USD, Year: {year}");
        }

        // Геттеры
        public string GetModel() => model;
        public string GetManufacturer() => manufacturer;
        public double GetPrice() => price;
        public int GetYear() => year;

        // Сеттеры
        public void SetPrice(double p)
        {
            if (p < 0)
            {
                throw new ArgumentException("Price cannot be negative.");
            }
            price = p;
        }

        public void SetYear(int y)
        {
            int currentYear = 2023;
            if (y < 1980 || y > currentYear)
            {
                throw new ArgumentException($"Year must be between 1980 and {currentYear}.");
            }
            year = y;
        }
    }
}


