using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKGarage
{
    public class Vehicle
    {
        

        public Vehicle(string registrationNumber, string color)
        {
            RegistrationNumber = registrationNumber;
            Color = color;
        }

        public string RegistrationNumber { get; set; }
        public string Color { get; set; }
        

    }
}
