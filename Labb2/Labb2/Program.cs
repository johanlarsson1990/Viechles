using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static Labb2.Program;

namespace Labb2
{
    class Program
    {
        public static EVehicle Item;
        public static int input;
        public static string inputString;
        public static int i;
        public static List<IVehicle> vehicleList = new List<IVehicle>();



        static void Main(string[] args)
        {
            Menu();
            
            Console.ReadLine();
        }
        public static void Menu()
        {

            Console.WriteLine("----Welcome to Vehicles!----\n" +
                              "You're going to create an optional number of three specific\n" +
                              "vehicle types, cars, boats and motorcycles.\n" +
                              "Ready? Please press enter!");
            Console.ReadLine();
            Console.Clear();


            Console.WriteLine("How many Cars do you want to create?");
            
            Console.Clear();

            Console.WriteLine("How many Boats do you want to create?");
            
            Console.Clear();

            Console.WriteLine("How many Motorcycles do you want to create?");
            
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
                    case (int)EVehicle.CAR:
                        
                        
                        break;
                    case (int)EVehicle.BOAT:
                        
                        break;
                    case (int)EVehicle.MOTORCYCLE:
                        
                        break;
                    case 4:
                        
                        

                        Console.WriteLine("Press any key to go back to main menu.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        break;

                }
            }
            

        }

        public static void AddVehicle()
        {
            if
        }


        //public static void PrintSpeedInMetersPerSecond(IVehicle vehicleToPrint)
        //{
        //    const double mpH = 0.447;
        //    const double knots = 0.514;
        //    const double kmH = 0.278;


        //    if (vehicleToPrint is Car)
        //    {
        //        Console.WriteLine($"-- {vehicleToPrint.VehicleList.Count} Cars in stock --");
        //        foreach (var i in vehicleToPrint.VehicleList)
        //        {
        //            Console.WriteLine($"{vehicleToPrint.VehicleType} {vehicleToPrint.VehicleList.IndexOf(i)} - {Math.Round(i * mpH, 2)} m/s"); 
        //        }


        //    }

        //    else if (vehicleToPrint is Boat)
        //    {
        //        Console.WriteLine($"-- {vehicleToPrint.VehicleList.Count} Boats in stock --");
        //        foreach (var i in vehicleToPrint.VehicleList)
        //        {
        //            Console.WriteLine($"{vehicleToPrint.VehicleType} {vehicleToPrint.VehicleList.IndexOf(i)} - {Math.Round(i * knots, 2)} m/s");
        //        }

        //    }

        //    else if (vehicleToPrint is Motorcycle)
        //    {
        //        Console.WriteLine($"-- {vehicleToPrint.VehicleList.Count} Motorcycles in stock --");
        //        foreach (var i in vehicleToPrint.VehicleList)
        //        {
        //            Console.WriteLine($"{vehicleToPrint.VehicleType} {vehicleToPrint.VehicleList.IndexOf(i)} - {Math.Round(i * kmH, 2)} m/s");
        //        }
        //    }

        //    Console.WriteLine($"\n" +
        //                      $"-----------------\n" +
        //                      $"");
        //}

    }

    
}
