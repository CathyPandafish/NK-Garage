using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKGarage
{
   public class Vehicle
    {
        public Vehicle(int registrationNumber, string color , int nrOfWheels, int doors, string brand)
        {
            RegistrationNumber = registrationNumber;
            Color = color;
            NrofWheels = nrOfWheels;
            Doors = doors;
            Brand = brand;

        }

        public int RegistrationNumber { get; set; }
        public string Color { get; set; }
        public int NrofWheels { get; set; }
        public int Doors { get; set; }
        public string Brand { get; set; }

    }
}
