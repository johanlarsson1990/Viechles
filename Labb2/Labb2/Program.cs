using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Labb2
{
    

    class Program
    {
        public static List<IVehicle> filterV = new List<IVehicle>();
        public static List<IVehicle> vehicles = new List<IVehicle>();
        public static IVehicle Item;
        public static int input;
        public static string inputString;
        public static int i;
        public static Random random = new Random();
        public static Boat boat = new Boat();
        static void Main(string[] args)
        {
            Menu();

            Console.ReadLine();
        }
        public static void Menu()
        {

            Console.WriteLine("----Welcome to Vehicles!----\n" +
                              "You're going to create an optional number of three specific\n" +
                              "vehicle types, Cars, Boats and Motorcycles.\n" +
                              "Ready? Please press enter!");
            Console.ReadLine();
            Console.Clear();


            Console.WriteLine("How many Cars do you want to create?");
            AddVehicle(int.Parse(Console.ReadLine()), Vehicle.Car);
            //Car.CreateList(int.Parse(Console.ReadLine()));
            Console.Clear();

            Console.WriteLine("How many Boats do you want to create?");
            AddVehicle(int.Parse(Console.ReadLine()), Vehicle.Boat);
            //Boat.CreateList(int.Parse(Console.ReadLine()));
            Console.Clear();
            
            Console.WriteLine("How many Motorcycles do you want to create?");
            AddVehicle(int.Parse(Console.ReadLine()), Vehicle.Motorcycle);
            //Motorcycle.CreateList(int.Parse(Console.ReadLine()));
            Console.Clear();



            // while
            while (true)
            {
                Console.WriteLine("-- Please select --\n" +
                                  "1. Print/Create Cars\n" +
                                  "2. Print/Create Boats\n" +
                                  "3. Print/create Motorcycles\n" +
                                  "4. Print all vehicles in m/s");
                input = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (input)
                {
                    case 1:
                        //Skriver ut alla Car's
                             WriteList(vehicles.FindAll(x => x.type == Vehicle.Car), "Car", "mph");

                        if (inputString == "+")
                        {
                            AddVehicle(1, Vehicle.Car,true);
                              continue;
                        }

                        else
                        {
                              ShowSpecificVehicle(Item, "mph");

                            if (inputString == "-")
                            {
                                RemoveVehicle(Item);
                                continue;
                            }
                            else
                            {
                                ChangeSpeed(Item);
                                continue;
                            }
                        }

                        break;
                    case 2:
                        //Skriver ut alla Boat's
                               WriteList(vehicles.FindAll(x => x.type == Vehicle.Boat), "Boat", "knots");


                        if (inputString == "+")
                        {
                               AddVehicle(1, Vehicle.Boat,true);
                               continue;
                        }

                        else
                        {
                               ShowSpecificVehicle(Item, "knots");

                            if (inputString == "-")
                            {
                                RemoveVehicle(Item);
                                continue;
                            }
                            else
                            {
                                ChangeSpeed(Item);
                                continue;
                            }
                        }
                        break;
                    case 3:
                        //Skriver ut alla Motorcycle's
                                WriteList(vehicles.FindAll(x => x.type == Vehicle.Motorcycle), "Motorcycle", "km/h");


                        if (inputString == "+")
                        {
                                AddVehicle(1, Vehicle.Motorcycle,true);
                               continue;
                        }

                        else
                        {
                                ShowSpecificVehicle(Item, "km/h");

                            if (inputString == "-")
                            {
                                RemoveVehicle(Item);
                                continue;
                            }
                            else
                            {
                                ChangeSpeed(Item);
                                continue;
                            }
                        }
                        break;
                    case 4:
                        PrintSpeedInMetersPerSecond(vehicles.FindAll(x => x.type == Vehicle.Boat));
                        break;
                    default:
                        break;

                }
            }

        }
        public static void WriteList(List<IVehicle> list, string vehicle, string speedUnit)
        {
            
            Console.WriteLine($"-- {list.Count} {vehicle}s in stock --");
           
            foreach (var i in list)
                Console.WriteLine($"{i.Name} - {i.Speed} {speedUnit}");
           
            Console.WriteLine($"----------------");
            Console.WriteLine($"Please select {vehicle} to change (1-{list.Count}) or enter + to add a new {vehicle}");
            inputString = Console.ReadLine();
            if (inputString != "+")
                Item = list[int.Parse(inputString)-1];
            
            Console.Clear();
        }

        public static void AddVehicle(int addera, Vehicle type, bool write =false)
        {
            var random = new Random();
            
            for (int i = 0; i < addera; i++)
            {
                if(type == Vehicle.Motorcycle)
                    vehicles.Add(new Motorcycle(random));
                if (type == Vehicle.Car)
                    vehicles.Add(new Car(random));
                if (type == Vehicle.Boat)
                    vehicles.Add(new Boat());
            }
            if (write)
            {
                 Console.WriteLine($"{type} added, press any key to go back to main menu");
                 Console.ReadKey();
                 Console.Clear();
            }
           
        }

        public static void ShowSpecificVehicle(IVehicle Item, string speedUnit)
        {
            input = int.Parse(inputString);
            
            Console.WriteLine($"-- {Item.Name} {input} --");
            Console.WriteLine($"Speed: {Item.Speed} {speedUnit}");
            Console.WriteLine("----------------");
            Console.WriteLine($"Please enter a new speed(0-100) or - to remove {Item.Name}");
            inputString = Console.ReadLine();
            Console.Clear();
        }

        public static void RemoveVehicle(IVehicle Item)
        {
            vehicles.Remove(Item);
            
            Console.WriteLine($"{Item.Name} removed, press any key to go back to main menu");
            Console.ReadKey();
        }

        public static void ChangeSpeed(IVehicle Item)
        {
            input = int.Parse(inputString);
            vehicles.Find(x => x.Name == Item.Name).Speed = input;
            
            Console.WriteLine($"{Item.Name} speed changed, press any key to go back to main menu");
            Console.ReadKey();
            Console.Clear();
        }

        public static void PrintSpeedInMetersPerSecond(List<IVehicle> vehicleToPrint)
        {
            const double mpH = 0.447;
            const double knots = 0.514;
            const double kmH = 0.278;

            if (vehicleToPrint )
            {
                

                foreach (var item in vehicleToPrint)
                {
                    Console.WriteLine($" {Item.Speed * knots} item * knots ");
                    
                }

                Console.ReadLine();
            }
        }

      
    }
}
