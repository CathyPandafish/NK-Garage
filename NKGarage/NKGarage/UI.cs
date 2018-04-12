using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKGarage
{
    public class UI
    {
        public void MainMenu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Please enter your option");
                Console.WriteLine("1) Garage");
                Console.WriteLine("2) Creat a new Garage");
                Console.WriteLine("0) quit");
            }
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "0":
                    keepRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid inout");
                    break;
            }
            Console.ReadLine();
        }

        public void FixedGarage()
        {
            Garage<Vehicle> g = new Garage<Vehicle>(50);
            
        }
    }
}
