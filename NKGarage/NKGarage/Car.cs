using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKGarage
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber, string color, string brand) : base(registrationNumber, color)
        {
            Brand = brand;
        }
        public string Brand { get; set; }
    }
}
