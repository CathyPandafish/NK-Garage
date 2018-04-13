using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKGarage
{
    public class Boat : Vehicle
    {
        public Boat(int registrationNumber, string color, int nrOfWheels, int doors, string brand , string fuelType) : base(registrationNumber, color, nrOfWheels, doors, brand)
        {
            FuelType = fuelType;
        }
        public String FuelType { get; set; }
    }
}
