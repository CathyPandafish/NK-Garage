using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKGarage
{
    public class Bus : Vehicle
    {
        public Bus(int registrationNumber, string color, int nrOfWheels, int doors, string brand , int nrOfSeats) : base(registrationNumber, color, nrOfWheels, doors, brand)
        {
            NrOfSeats = nrOfSeats;
                
        }
        public int NrOfSeats { get; set; }
    }
}
