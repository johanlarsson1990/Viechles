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
        public static List<IVehicle> vehicles = new List<IVehicle>();
        public static IVehicle Item;
        public static int input;
        public static string inputString;
        
        static void Main(string[] args)
        {
            Welcome();
            Menu();
        }

        /// <summary>
        /// Say welcome to user, explains the task, let the user input an optional number of each vehicle-type.
        /// </summary>
        public static void Welcome()
        {
            Console.WriteLine("----Welcome to Vehicles!----\n" +
                              "You're going to create an optional number of three specific\n" +
                              "vehicle types, Cars, Boats and Motorcycles.\n" +
                              "Ready? Please press enter!");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("How many Cars do you want to create?");
            ErrorHandling(Console.ReadLine());
            AddVehicle(input, Vehicle.Car);
            Console.Clear();

            Console.WriteLine("How many Boats do you want to create?");
            ErrorHandling(Console.ReadLine());
            AddVehicle(input, Vehicle.Boat);
            Console.Clear();

            Console.WriteLine("How many Motorcycles do you want to create?");
            ErrorHandling(Console.ReadLine());
            AddVehicle(input, Vehicle.Motorcycle);
            Console.Clear();
        }

        /// <summary>
        /// Calls the menu choice after valid input of each vehicle type
        /// calls specific methods based on the users input until the user chose to quit the program
        /// </summary>
        public static void Menu()
        {
            var run = true;
            while (run)
            {
                Console.WriteLine("-- Please select --\n" +
                                  "1. Print/Create Cars\n" +
                                  "2. Print/Create Boats\n" +
                                  "3. Print/create Motorcycles\n" +
                                  "4. Print all vehicles in m/s\n" +
                                  "5. Quit program");

                ErrorHandling(Console.ReadLine(),null,true);
                Console.Clear();

                switch (input)
                {
                    case 1:
                        WriteList(vehicles.FindAll(x => x.type == Vehicle.Car), "Car", "mph");

                        if (inputString == "+")
                        {
                            AddVehicle(1, Vehicle.Car, true);
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

                    case 2:
                        WriteList(vehicles.FindAll(x => x.type == Vehicle.Boat), "Boat", "knots");

                        if (inputString == "+")
                        {
                            AddVehicle(1, Vehicle.Boat, true);
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
                        
                    case 3:
                        WriteList(vehicles.FindAll(x => x.type == Vehicle.Motorcycle), "Motorcycle", "km/h");
                        
                        if (inputString == "+")
                        {
                            AddVehicle(1, Vehicle.Motorcycle, true);
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

                    case 4:
                        // skriver ut alla listor i m/s
                        vehicles = vehicles.OrderBy(x => x.Name).ToList();

                        Console.WriteLine("--Vehicles in m/s--");
                        foreach (var item in vehicles)
                        {
                            PrintSpeedInMetersPerSecond(item);
                        }

                        Console.WriteLine("\n" +
                                          "----------------\n" +
                                          "Press any key to return to main menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        run = false;
                        break;
                }
            }

        }
        
        
        /// <summary>
        /// Adds vehicle by chosen type in the public Ivehicle list.
        /// </summary>
        /// <param name="addera"> how many to add to list </param>
        /// <param name="type"> type of vehicle </param>
        /// <param name="write"></param>
        public static void AddVehicle(int addera, Vehicle type, bool write = false)
        {
            var random = new Random();

            for (int i = 0; i < addera; i++)
            {
                if (type == Vehicle.Motorcycle)
                    vehicles.Add(new Motorcycle(random));
                if (type == Vehicle.Car)
                    vehicles.Add(new Car(random));
                if (type == Vehicle.Boat)
                    vehicles.Add(new Boat(random));
            }
            if (write)
            {
                Console.WriteLine($"{type} added, press any key to go back to main menu");
                Console.ReadKey();
                Console.Clear();
            }
        }

        /// <summary>
        /// Writes out a list of vehicle, by chosen type
        /// </summary>
        /// <param name="list"> takes in the public Ivehicle list</param>
        /// <param name="vehicle"> </param>
        /// <param name="speedUnit"></param>
        public static void WriteList(List<IVehicle> list, string vehicle, string speedUnit)
        {

            Console.WriteLine($"-- {list.Count} {vehicle}s in stock --");
            for (int i = 0; i < list.Count; i++)
            {
                var index = i+1;
                Console.WriteLine($"{index}. {list[i].Name} - {list[i].getSpeed()} {speedUnit}");
            }
            
            Console.WriteLine($"----------------");
            Console.WriteLine($"Please select {vehicle} to change (1-{list.Count}) or enter + to add a new {vehicle}");
            ErrorHandling(Console.ReadLine(),list,false,true);
            
            Console.Clear();
        }

        /// <summary>
        /// Show the chosen vehicle of the given type. For further tasks
        /// </summary>
        /// <param name="Item"></param>
        /// <param name="speedUnit"></param>
        public static void ShowSpecificVehicle(IVehicle Item, string speedUnit)
        {
            
            ErrorHandling(inputString);
            Console.WriteLine($"-- {Item.Name} --");
            Console.WriteLine($"Speed: {Item.getSpeed()} {speedUnit}");
            Console.WriteLine("----------------");
            Console.WriteLine($"Please enter a new speed(0-100) or - to remove {Item.Name}");
            
            ErrorHandling(Console.ReadLine(),null,true,true);
            Console.Clear();
        }

        /// <summary>
        /// Removes the chosen vehicle from Ivehicle list 
        /// </summary>
        /// <param name="Item"></param>
        public static void RemoveVehicle(IVehicle Item)
        {
            vehicles.Remove(Item);

            Console.WriteLine($"{Item.Name} removed, press any key to go back to main menu");
            Console.ReadKey();
        }

        /// <summary>
        /// Change the speed of the chosen vehicle
        /// </summary>
        /// <param name="Item"></param>
        public static void ChangeSpeed(IVehicle Item)
        {
            
            vehicles.Find(x => x.Name == Item.Name).setSpeed(input);

            Console.WriteLine($"{Item.Name} speed changed, press any key to go back to main menu");
            Console.ReadKey();
            Console.Clear();
        }


        /// <summary>
        /// Convert the chosen vehicles speed unit to m/s and display  it on the console.
        /// </summary>
        /// <param name="vehicleToPrint"></param>
        public static void PrintSpeedInMetersPerSecond(IVehicle vehicleToPrint)
        {
         
            double ms = 0;
           
            if (vehicleToPrint.type==Vehicle.Car)
            {
                ms = vehicleToPrint.Speed * 0.447;
            }
            
            else if (vehicleToPrint.type==Vehicle.Boat)
            {
                ms = vehicleToPrint.Speed * 0.514;
            }

            else if (vehicleToPrint.type==Vehicle.Motorcycle)
            {
                ms = vehicleToPrint.Speed * 0.278;
            }
            Console.WriteLine($"{vehicleToPrint.Name} - {ms} - m/s");
        }

        /// <summary>
        /// Takes care of exception handling, checks if the user enter a valid input for the question.   
        /// </summary>
        /// <param name="error"></param>
        /// <param name="fordon"></param>
        /// <param name="menuOrRemove"></param>
        /// <param name="add"></param>
        public static void ErrorHandling(string error, List<IVehicle> fordon = null,bool menuOrRemove=false,bool add=false)
        {
            var output = 0;
            var wrong = true;
            while (wrong)
            {
                var test = int.TryParse(error, out output);
                if (menuOrRemove && error == "-" && add || error == "+" && add && menuOrRemove == false)
                {
                    inputString = error;
                    wrong = false;

                }
                else if (fordon != null && output > 0 && output <= fordon.Count && test == true)
                {
                    Item = fordon[output-1];
                    inputString = error;
                    wrong = false;
                }
                else if (menuOrRemove && output >= 1 && output <= 5)
                {
                    input = output;
                    wrong = false;
                }
                else if(test && output >= 0 && output <= 100 && fordon == null)
                {
                    input = output;
                    inputString = error;
                    wrong = false;
                }
                else
                {
                    Console.WriteLine("Wrong input, try again");
                    error = Console.ReadLine();
                }
                
            }
        }
        
        
        
    
      
        // Samma funktion som print+case4 på ett ställe, mer lättläsligt!!!!!!!!!!!!!!!!!
        // Caset sen mycket "cleanare" ut med koden nedanför.

        //public static void PrintSpeedInMetersPerSecond()
        //{
        //    vehicles = vehicles.OrderBy(x => x.Name).ToList();
        //    double ms = 0;
            
        //    foreach (var item in vehicles)
        //    {
        //        if (item.type == Vehicle.Car)
        //        {
        //            ms = item.Speed * 0.447;
        //        }

        //        else if (item.type == Vehicle.Boat)
        //        {
        //            ms = item.Speed * 0.514;
        //        }

        //        else if (item.type == Vehicle.Motorcycle)
        //        {
        //            ms = item.Speed * 0.278;
        //        }
        //        Console.WriteLine($"{item.Name} - {ms} - m/s");
        //    }
        //    Console.WriteLine("Press any key to return to main menu");
        //    Console.ReadKey();
        //    Console.Clear();
        //}
    }
}
