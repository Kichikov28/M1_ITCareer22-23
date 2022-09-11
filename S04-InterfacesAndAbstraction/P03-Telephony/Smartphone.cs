using System;
using System.Collections.Generic;
using System.Text;

namespace P03_Telephony
{
    public class Smartphone : INumber
    {
        public Smartphone(double number)
        {
            this.Number = number;
        }
        public void Browsing()
        {
            Console.WriteLine("Browsing...");
        }

        public double Number { get; set; }
    }
}
