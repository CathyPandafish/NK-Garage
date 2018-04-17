using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKGarage
{
    public class UI
    {
        Garage<Vehicle> g;
        public void MainMenu()
        {
            

            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Please enter your option");
                Console.WriteLine("1) Creat your Garage");
                Console.WriteLine("2) Park");
                Console.WriteLine("3) Unpark");
                Console.WriteLine("4) Print out all parked cars in garage");
                Console.WriteLine("5) Print out parked vehicle types in garage");
                Console.WriteLine("0) quit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1": CreateGarage();
                        break;
                    case "2": Park();
                        break;
                    case "3":
                        break;
                    case "4":
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

        }


        public void CreateGarage()
        {
            Console.WriteLine("How many parking spots in a garage do you want to create? ");
            int number = int.Parse(Console.ReadLine());
            g = new Garage<Vehicle>(number);
        }

        public void Park()
        {
            Console.WriteLine("Enter the type of Vehicles");
            Console.WriteLine("1) Airplan");
            Console.WriteLine("2) Bus");
            Console.WriteLine("3) Car");
            Console.WriteLine("4) Boat");
            Console.WriteLine("5) Motorcycle");
            Console.WriteLine("0) Quit");

            int opt = int.Parse(Console.ReadLine());

            if (opt == 1)
            {
                Console.WriteLine("Registeration Number: ");
                string regNr = Console.ReadLine();
                Console.WriteLine(" Color: ");
                string color = Console.ReadLine();
                Console.WriteLine("Number of Engine: ");
                string nrOfEngineasString = Console.ReadLine();
                int nrOfEngine;
                int.TryParse(nrOfEngineasString, out nrOfEngine);

                Airplane airplane = new Airplane(regNr, color, nrOfEngine);
                g.Add(new Airplane(regNr, color, nrOfEngine));
            }

            if (opt == 2)
            {
            }


            Console.ReadLine();
        }

        public void AllList()
        {

        }
    }
}
         

        



        //for (int i = 0; i < number; i++)
        //{

        //    Console.WriteLine("Vehicle´s registration number: ");
        //    string nrOfRegisteration = Console.ReadLine();
        //    Console.WriteLine("Vehicle´s color: ");
        //    string color = Console.ReadLine();
        //    Console.WriteLine("Number of wheels: ");
        //    int nrOfWheels = int.Parse(Console.ReadLine());
        //    Console.WriteLine("How many doors does your vehicle have?");
        //    int nrOfDoors = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Brand of your vehicle: ");
        //    string brand = Console.ReadLine();
        //    Vehicle vehicle = new Vehicle(nrOfRegisteration, color, nrOfDoors, nrOfWheels, brand);
        //    g.Add(vehicle);
        //}

        //foreach (var a in g)
        //{
        //    Console.WriteLine(a.Color + " " + a.Brand + " with registrationNumber " + a.RegistrationNumber + " has " + a.NrofWheels + " wheels and " + a.Doors + " doors");
        //}

        //foreach (var a in g.Where(x => x.g))
        //{
        //    Console.WriteLine();
        //}
        
        
     

    
         



               
               

            //    foreach (Vehicle a in g.Where(x => x.Doors >3).OrderBy(x => x.Doors))
            //{
            //    Console.WriteLine(a.RegistrationNumber + " has " + a.Doors + " and it is " + a.Color + a.Brand);

            //}

    


