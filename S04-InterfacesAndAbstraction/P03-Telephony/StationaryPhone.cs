using System;
using System.Collections.Generic;
using System.Text;

namespace P03_Telephony
{
    public class StationaryPhone : INumber
    {
        public StationaryPhone(double number)
        {
            this.Number = number;
        }

        public double Number { get; set; }
    }
}
