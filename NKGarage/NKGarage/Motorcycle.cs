using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKGarage
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle(string registrationNumber, string color,string model) : base(registrationNumber, color)
        {
            Model = model;
        }
        public string Model { get; set; }
    }
}
