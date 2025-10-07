using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_C_
{
    public class WashingMachine : HomeAppliance
    {
        private double capacity;
        private string washType;
        private int spinSpeed;

        public WashingMachine(string m = "Unknown", string manu = "Unknown", double p = 0.0, int y = 2000,
                            double cap = 7.0, string wt = "Front Load", int ss = 1200)
            : base(m, manu, p, y)
        {
            if (cap <= 0)
            {
                throw new ArgumentException("Capacity must be positive.");
            }
            if (ss <= 0)
            {
                throw new ArgumentException("Spin speed must be positive.");
            }

            capacity = cap;
            washType = wt;
            spinSpeed = ss;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Capacity: {capacity} kg, Wash Type: {washType}, Spin Speed: {spinSpeed} rpm");
        }

        // Геттеры и сеттеры
        public double GetCapacity() => capacity;

        public void SetCapacity(double cap)
        {
            if (cap <= 0)
            {
                throw new ArgumentException("Capacity must be positive.");
            }
            capacity = cap;
        }

        public string GetWashType() => washType;
        public void SetWashType(string wt) => washType = wt;

        public int GetSpinSpeed() => spinSpeed;

        public void SetSpinSpeed(int ss)
        {
            if (ss <= 0)
            {
                throw new ArgumentException("Spin speed must be positive.");
            }
            spinSpeed = ss;
        }
    }
}