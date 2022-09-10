using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class FamilyCar:Car
    {
        public FamilyCar(int horsePower, double fuel)
            : base(horsePower, fuel)
        {
            this.DefaultFuelConsumption = 1.25;
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }
    }
}
