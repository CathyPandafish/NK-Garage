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


        private T[] Vihecle;
        int cap, count;

        public Garage(int capacity)
        {
            cap = capacity;
            count = 0;
            Vihecle = new T[capacity];

        }

        public void Add(T input)
        {
            if (cap > count)
            {
                Vihecle[count] = input;
                count += 1;
            }

        }


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return Vihecle[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
          

            return GetEnumerator();
        }

        //public void Remove (string input)
        //{
        //    for (int i = 0; i < Vehicle.count; i++)
        //    {
        //        if (Vehicle.count() -1);
        //    }
        }
    }

