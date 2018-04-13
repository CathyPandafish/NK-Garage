using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKGarage
{
    public class Car : Vehicle
    {
        public Car(int registrationNumber, string color, int nrOfWheels, int doors, string brand, bool sportCar) : base(registrationNumber, color, nrOfWheels, doors, brand)
        {
            SportCar = sportCar;
        }
        public bool SportCar { get; set; }
    }
}
