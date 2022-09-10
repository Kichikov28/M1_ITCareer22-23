using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Fish:MainDish
    {
        public Fish(string name, decimal price, double grams)
          : base(name, price, grams)
        {     
            this.Name = name;
            this.Price = price;
            this.Grams = grams;
            this.Grams = 22;

        }
    }
}
