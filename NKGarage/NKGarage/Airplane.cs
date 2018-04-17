using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKGarage
{
    public class  Airplane : Vehicle
    {
        public Airplane(string registrationNumber, string color, int nrOfEngines ) : base(registrationNumber, color)
        {
            NrOfEngines = nrOfEngines;
        }

        public int NrOfEngines { get; set; }
    }
} 
