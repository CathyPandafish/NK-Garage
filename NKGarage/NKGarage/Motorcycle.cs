using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKGarage
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle(int registrationNumber, string color, int nrOfWheels, int doors, string brand, string model) : base(registrationNumber, color, nrOfWheels, doors, brand)
        {
            Model = model;
        }
        public string Model { get; set; }
    }
}
