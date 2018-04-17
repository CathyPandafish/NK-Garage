using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKGarage
{
    public class Bus : Vehicle
    {
        public Bus(string registrationNumber, string color, int nrOfSeats) : base(registrationNumber, color)
        {
            NrOfSeats = nrOfSeats;
                
        }
        public int NrOfSeats { get; set; }
    }
}
