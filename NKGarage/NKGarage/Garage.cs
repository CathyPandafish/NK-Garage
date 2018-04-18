using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKGarage
{
    public class Garage<T> : IEnumerable<T> where T : Vehicle
    {


        private List<T> vehicles;
        int cap;

        public Garage(int capacity)
        {
            cap = capacity;
            
            vehicles = new List<T>();

        }

        public void Park(T vehicle)
        {
            if (cap > vehicles.Count )
            {
                vehicles.Add(vehicle);
              
            }
        }
        public void Unpark(T vehicle)
        {
          
                vehicles.Remove(vehicle);
            
        }


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < vehicles.Count; i++)
            {
                yield return vehicles[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}