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
    public enum EVehicle {ERROR, CAR, BOAT, MOTORCYCLE }
    class Program
    {
        public static EVehicle vehicleInput;
        public static int input;
        public static string inputString;
        public static int i;
        public static Random random = new Random();
        public static Car car = new Car();
        public static Boat boat = new Boat();
        public static Motorcycle motorcycle = new Motorcycle();
        

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
            car.CreateList(int.Parse(Console.ReadLine()));
            Console.Clear();

            Console.WriteLine("How many Boats do you want to create?");
            boat.CreateList(int.Parse(Console.ReadLine()));
            Console.Clear();

            Console.WriteLine("How many Motorcycles do you want to create?");
            motorcycle.CreateList(int.Parse(Console.ReadLine()));
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
                        
                        VehicleTypeChoice(car);
                        break;
                    case 2:
                        VehicleTypeChoice(boat);
                        break;
                    case 3:
                        VehicleTypeChoice(motorcycle);
                        break;
                    case 4:
                        var meterPerSecondList = new List<IVehicle>
                        {
                            car,
                            boat,
                            motorcycle
                        };
                        PrintSpeedInMetersPerSecond(car);
                        PrintSpeedInMetersPerSecond(boat);
                        PrintSpeedInMetersPerSecond(motorcycle);

                        Console.WriteLine("Press any key to go back to main menu.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        break;

                }
            }
            

        }

        public static void VehicleTypeChoice(IVehicle type)
        {
            
            
            type.WriteList();

            inputString = Console.ReadLine();
            Console.Clear();
            if (inputString == "+")
            {
                type.AddVehicle();

                Console.ReadKey();
                Console.Clear();
                //continue;
            }

            else
            {
                input = int.Parse(inputString);
                i = input;

                type.IndexedVehicle(i);

                inputString = Console.ReadLine();
                Console.Clear();

                if (inputString == "-")
                {
                    type.RemoveVehicle(i);
                    Console.ReadKey();
                    Console.Clear();
                    //continue;
                }
                else
                {
                    input = int.Parse(inputString);
                    type.Speed = input;
                    type.ChangeSpeed(i);
                    Console.ReadKey();
                    //continue;
                }
            }
        }

        public static void PrintSpeedInMetersPerSecond(IVehicle vehicleToPrint)
        {
            const double mpH = 0.447;
            const double knots = 0.514;
            const double kmH = 0.278;
            

            if (vehicleToPrint is Car)
            {
                Console.WriteLine($"-- {vehicleToPrint.VehicleList.Count} {vehicleToPrint.VehicleType}s in stock --");
                foreach (var i in vehicleToPrint.VehicleList)
                {
                    Console.WriteLine($"{vehicleToPrint.VehicleType} {vehicleToPrint.VehicleList.IndexOf(i)} - {Math.Round(i * mpH, 2)} m/s"); 
                }

                
            }

            else if (vehicleToPrint is Boat)
            {
                Console.WriteLine($"-- {vehicleToPrint.VehicleList.Count} {vehicleToPrint.VehicleType}s in stock --");
                foreach (var i in vehicleToPrint.VehicleList)
                {
                    Console.WriteLine($"{vehicleToPrint.VehicleType} {vehicleToPrint.VehicleList.IndexOf(i)} - {Math.Round(i * knots, 2)} m/s");
                }

            }

            else if (vehicleToPrint is Motorcycle)
            {
                Console.WriteLine($"-- {vehicleToPrint.VehicleList.Count} {vehicleToPrint.VehicleType}s in stock --");
                foreach (var i in vehicleToPrint.VehicleList)
                {
                    Console.WriteLine($"{vehicleToPrint.VehicleType} {vehicleToPrint.VehicleList.IndexOf(i)} - {Math.Round(i * kmH, 2)} m/s");
                }
            }

            Console.WriteLine($"\n" +
                              $"-----------------\n" +
                              $"");
        }
        
    }
}
