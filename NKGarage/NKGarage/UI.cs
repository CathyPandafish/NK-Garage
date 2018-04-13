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

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        FixedGarage();
                        break;
                    case "2":
                        break;
                    case "0":
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
                Console.Write("\n <PRESS ANY BUTTON TO CONTINUE>");
                Console.ReadLine();
            }

           // Garage<Vehicle> g = new Garage<Vehicle>(50);
           // g.Add(new Vehicle());
        }

        public void FixedGarage()
        {
            bool UserOption = true;
            while (UserOption)
            {

                Console.ReadLine();
                Console.WriteLine("Vehicle´s registration number: ");
                int nrOfRegisteration = int.Parse(Console.ReadLine());
                Console.WriteLine("Vehicle´s color: ");
                string color = Console.ReadLine();
                Console.WriteLine("Number of wheels: ");
                int nrOfWheels = int.Parse(Console.ReadLine());
                Console.WriteLine("How many doors does your vehicle have?");
                int nrOfDoors = int.Parse(Console.ReadLine());
                Console.WriteLine("Brand of your vehicle: ");
                string brand = Console.ReadLine();
                break;
            
            }
        }
      
         



               
               

            //    foreach (Vehicle a in g.Where(x => x.Doors >3).OrderBy(x => x.Doors))
            //{
            //    Console.WriteLine(a.RegistrationNumber + " has " + a.Doors + " and it is " + a.Color + a.Brand);

            //}

    }
}

