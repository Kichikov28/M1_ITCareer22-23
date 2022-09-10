using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Cake:Dessert
    {
        public Cake(string name, decimal price, double grams, double calories)
             : base(name, price=5, grams=250,calories=1000)
        {
            this.Name = name;
            this.Price = price;     
            this.Grams = grams;
            this.Calories = calories;
        }
    }
}
