using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKGarage
{
    public class Airplane : Vehicle
    {
        public Airplane(int registrationNumber, string color, int nrOfWheels, int doors, string brand, int manaCap) : base(registrationNumber, color, nrOfWheels, doors, brand)
        {
            ManaCap = manaCap;
        }

        public int ManaCap { get; set; }
    }
} 
