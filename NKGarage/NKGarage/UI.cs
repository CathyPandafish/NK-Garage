using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKGarage
{
    public class UI
    {
        private bool message;
        private int userValue;

        public void MainMenu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Please enter your option");
                Console.WriteLine("1) Creat Garage");
                Console.WriteLine("2) Park");
                Console.WriteLine("3) Unpark");
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

            //Garage<Vehicle> g = new Garage<Vehicle>(50);
            // g.Add(new Vehicle());
        }

        public void FixedGarage()

        {
        //    Console.WriteLine("Enter the num of Garage size:");
        //    int Usersize = int.Parse(Console.ReadLine());
        //    Garage<Vehicle> g = new Garage<Vehicle>(Usersize);
        //    bool UserOption = true;
        //    while (UserOption)
        //    {

        //        Console.ReadLine();
        //        Console.WriteLine("Vehicle´s registration number: ");
        //        string nrOfRegisteration = Console.ReadLine();
        //        Console.WriteLine("Vehicle´s color: ");
        //        string color = Console.ReadLine();
        //        Console.WriteLine("Number of wheels: ");
        //        string nrOfWheels = Console.ReadLine();
        //        Console.WriteLine("How many doors does your vehicle have?");
        //        string nrOfDoors = Console.ReadLine();
        //        Console.WriteLine("Brand of your vehicle: ");
        //        string brand = Console.ReadLine();



        //        foreach (Vehicle a in g.Where(x => x.Doors > 3).OrderBy(x => x.Doors))
        //        {
        //            Console.WriteLine(a.RegistrationNumber + " has " + a.Doors + " and it is " + a.Color + a.Brand);
                   
        //        }








                Console.WriteLine(  " How many bus you want to add :");
                int length1 = int.Parse(Console.ReadLine());
                for (int i = 0; i < length1; i++)
                {
                    Console.WriteLine("enter the bus registeration no");
                    int regstrationNo = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter the color");
                    string Color = Console.ReadLine();
                    Console.WriteLine("enter the NrofWheels" );
                    int NrofWheels = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter the brand"  );
                    string Brand = Console.ReadLine();
                    Console.WriteLine("enter the Doors " );
                    int Doors = int.Parse(Console.ReadLine());









               //    g.Add(new Bus(regstrationNo, color, NrofWheels());

               // }
               //  Console.WriteLine("do you want to add more buse?(yes\no) ");

               //char choice = Convert.ToChar(Console.ReadLine());

               // //if (choice =="no")

               //{
                   
                  
               //    return;
               //}
                

            }
            
       
        }

    }
}

