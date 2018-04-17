using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKGarage
{
    public class Boat : Vehicle
    {
        public Boat(string registrationNumber, string color, string fuelType) : base(registrationNumber, color)
        {
            FuelType = fuelType;
        }
        public String FuelType { get; set; }
    }
}
