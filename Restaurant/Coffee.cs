using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee:HotBeverage
    {
        public Coffee(string name, decimal price, double milliliters)
            : base(name, price,milliliters)
        {
            this.Name = name;
            this.Price = price;
            this.Milliliters = milliliters;
            
        }
        double CoffeeMilliliters = 50;
        double CoffeePrice = 3.50;
        public double Caffeine { get; set; }
    }
}
