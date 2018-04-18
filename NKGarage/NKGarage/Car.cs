﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKGarage
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber, string color, string sportCar) : base(registrationNumber, color)
        {
            SportCar = sportCar;
        
        }
        public string  SportCar { get; set; }
    }
}
