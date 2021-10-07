using System;
using System.Collections.Generic;
using System.Linq;
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
            Menu();

            Console.ReadLine();
        }
        public static void Menu()
        {
            Welcome();

            // while
            while (true)
            {
                Console.WriteLine("-- Please select --\n" +
                                  "1. Print/Create Cars\n" +
                                  "2. Print/Create Boats\n" +
                                  "3. Print/create Motorcycles\n" +
                                  "4. Print all vehicles in m/s");
                errorHandeling(Console.ReadLine(),null,true);
                Console.Clear();

                switch (input)
                {
                    case 1:
                        //Skriver ut alla Car's
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

                        break;
                    case 2:
                        //Skriver ut alla Boat's
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
                        break;
                    case 3:
                        //Skriver ut alla Motorcycle's
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
                        break;
                    case 4:
                        // skriver ut alla listor i m/s
                        vehicles = vehicles.OrderBy(x => x.Name).ToList();

                        foreach (var item in vehicles)
                        {
                            PrintSpeedInMetersPerSecond(item);
                        }
                        Console.WriteLine("Press any key to return to main menu");
                        Console.ReadKey();
                        Console.Clear();
                        //PrintSpeedInMetersPerSecond();
                        break;
                    default:
                        break;

                }
            }

        }
        public static void Welcome ()
        {
            Console.WriteLine("----Welcome to Vehicles!----\n" +
                              "You're going to create an optional number of three specific\n" +
                              "vehicle types, Cars, Boats and Motorcycles.\n" +
                              "Ready? Please press enter!");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("How many Cars do you want to create?");
            errorHandeling(Console.ReadLine());
            AddVehicle(input, Vehicle.Car);
            //AddVehicle(int.Parse(Console.ReadLine()), Vehicle.Car);
            //AddVehicle(int.Parse(felhantering(Console.ReadLine())), Vehicle.Car);
            Console.Clear();

            Console.WriteLine("How many Boats do you want to create?");
            errorHandeling(Console.ReadLine());
            AddVehicle(input, Vehicle.Boat);
            Console.Clear();

            Console.WriteLine("How many Motorcycles do you want to create?");
            errorHandeling(Console.ReadLine());
            AddVehicle(input, Vehicle.Motorcycle);
            Console.Clear();
        }
        public static void WriteList(List<IVehicle> list, string vehicle, string speedUnit)
        {

            Console.WriteLine($"-- {list.Count} {vehicle}s in stock --");
            for (int i = 0; i < list.Count; i++)
            {
                var index = i+1;
                Console.WriteLine($"{index}. {list[i].Name} - {list[i].getSpeed()} {speedUnit}");
            }
            //foreach (var i in list)
            //    Console.WriteLine($"{i.Name} - {i.getSpeed()} {speedUnit}");

            Console.WriteLine($"----------------");
            Console.WriteLine($"Please select {vehicle} to change (1-{list.Count}) or enter + to add a new {vehicle}");
            //inputString = felhantering(Console.ReadLine());
            errorHandeling(Console.ReadLine(),list,false,true);
            //if (inputString != "+")
            //{
            //    Item = list[int.Parse(felhantering(inputString, list.Count,true)) -1];
            //}
            Console.Clear();
        }

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

        public static void ShowSpecificVehicle(IVehicle Item, string speedUnit)
        {
            //input = int.Parse(felhantering(inputString));
            errorHandeling(inputString);
            Console.WriteLine($"-- {Item.Name} --");
            Console.WriteLine($"Speed: {Item.getSpeed()} {speedUnit}");
            Console.WriteLine("----------------");
            Console.WriteLine($"Please enter a new speed(0-100) or - to remove {Item.Name}");
            //inputString = felhantering(Console.ReadLine());
            errorHandeling(Console.ReadLine(),null,true,true);
            //if (inputString != "-")
            //    input = int.Parse(felhantering(inputString));
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
            
            //input = felhantering(inputString);
            vehicles.Find(x => x.Name == Item.Name).setSpeed(input);

            Console.WriteLine($"{Item.Name} speed changed, press any key to go back to main menu");
            Console.ReadKey();
            Console.Clear();
        }

        public static void PrintSpeedInMetersPerSecond(IVehicle vehicletoprint)
        {
         
            double ms = 0;
           
            if (vehicletoprint.type==Vehicle.Car)
            {
                ms = vehicletoprint.Speed * 0.447;
            }
            
            else if (vehicletoprint.type==Vehicle.Boat)
            {
                ms = vehicletoprint.Speed * 0.514;
            }

            else if (vehicletoprint.type==Vehicle.Motorcycle)
            {
                ms = vehicletoprint.Speed * 0.278;
            }
            Console.WriteLine($"{vehicletoprint.Name} - {ms} - m/s");
        }
        public static void errorHandeling(string error, List<IVehicle> fordon = null,bool menyOrRemove=false,bool add=false)
        {
            int output = 0;
            bool wrong = true;
            while (wrong)
            {
                var test = int.TryParse(error, out output);
                if (menyOrRemove && error == "-" && add || error == "+" && add && menyOrRemove == false)
                {
                    inputString = error;
                    wrong = false;

                }
                else if (fordon != null && output >= 0 && output < fordon.Count && test == true)
                {
                    Item = fordon[output-1];
                    inputString = error;
                    wrong = false;
                }
                else if (menyOrRemove && output >= 1 && output < 4)
                {
                    input = output;
                    wrong = false;
                }
                else if(test && output >= 0 && output < 100 && fordon == null)
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
