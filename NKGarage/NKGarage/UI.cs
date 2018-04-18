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
                    case "1":
                        CreateGarage();
                        break;
                    case "2":
                        Park();
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

                g.Add(new Airplane(regNr, color, nrOfEngine));
                
            }

            if (opt == 2)
               
            {
                Console.WriteLine("Registeration Number: ");
                string regNr = Console.ReadLine();
                Console.WriteLine(" Color: ");
                string color = Console.ReadLine();
                Console.WriteLine("nrOfSeats: ");
                string nrOfEngineasString = Console.ReadLine();
                int nrOfSeats;
                int.TryParse(nrOfEngineasString, out nrOfSeats);

                g.Add(new Bus(regNr, color, nrOfSeats));
           
            }
          
            if (opt == 3)
            {
                Console.WriteLine("Registeration Number: ");
                string regNr = Console.ReadLine();
                Console.WriteLine(" Color: ");
                string color = Console.ReadLine();
                Console.WriteLine("sportCar: ");
                string sportCar = Console.ReadLine();
               
                g.Add(new Car(regNr, color, sportCar));
               
            }
            
            if (opt == 4)
            {
                Console.WriteLine("Registeration Number: ");
                string regNr = Console.ReadLine();
                Console.WriteLine(" Color: ");
                string color = Console.ReadLine();
                Console.WriteLine("fuelType : ");
                string fuelType = Console.ReadLine();
                g.Add(new Boat(regNr, color, fuelType));
            }

            if (opt == 5)
            {
                Console.WriteLine("Registeration Number: ");
                string regNr = Console.ReadLine();
                Console.WriteLine(" Color: ");
                string color = Console.ReadLine();
                Console.WriteLine("model : ");
                string model = Console.ReadLine();
         
                g.Add(new Motorcycle(regNr, color, model));
              
            }
        
            Console.ReadLine();

            
            //while (true)
            //{
            //    Console.WriteLine("To Unpark a Vehicle from garrage wrtite 0. Else Press Any Key.");
            //    char f = Convert.ToChar(Console.ReadLine());

            //    if (f == '0')
            //    {
            //        Console.WriteLine("enter the vehicle registration number you want to unpark from garrage:");
            //        string v = Console.ReadLine();
            //        object allVehicle = null;
            //        //alllVehicle.Delete(v);

            //        continue;
            //    }

            //    else
            //        break;

            }

        }

    }











