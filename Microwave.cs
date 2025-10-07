using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_C_
{
    public class Microwave : HomeAppliance
    {
        private double power;
        private string cookingType;
        private int turntableSize;

        public Microwave(string m = "Unknown", string manu = "Unknown", double p = 0.0, int y = 2000,
                        double pow = 700.0, string ct = "Convection", int ts = 28)
            : base(m, manu, p, y)
        {
            if (pow <= 0)
            {
                throw new ArgumentException("Power must be positive.");
            }
            if (ts <= 0)
            {
                throw new ArgumentException("Turntable size must be positive.");
            }

            power = pow;
            cookingType = ct;
            turntableSize = ts;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Power: {power} W, Cooking Type: {cookingType}, Turntable Size: {turntableSize} cm");
        }

        // Геттеры и сеттеры
        public double GetPower() => power;

        public void SetPower(double pow)
        {
            if (pow <= 0)
            {
                throw new ArgumentException("Power must be positive.");
            }
            power = pow;
        }

        public string GetCookingType() => cookingType;
        public void SetCookingType(string ct) => cookingType = ct;

        public int GetTurntableSize() => turntableSize;

        public void SetTurntableSize(int ts)
        {
            if (ts <= 0)
            {
                throw new ArgumentException("Turntable size must be positive.");
            }
            turntableSize = ts;
        }
    }
}
