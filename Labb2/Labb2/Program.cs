using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2
{
    enum Vehicle
    {
        car = 1,
        boat = 2,
        motorcycle = 3,
        allVehicle = 4
    }
    class Program
    {
        public static int input;
        public static string inputString;
        public static int i;
        public static Random random = new Random();
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
            Car.CreateList(int.Parse(Console.ReadLine()));
            Console.Clear();

            Console.WriteLine("How many Boats do you want to create?");
            Boat.CreateList(int.Parse(Console.ReadLine()));
            Console.Clear();

            Console.WriteLine("How many Motorcycles do you want to create?");
            Motorcycle.CreateList(int.Parse(Console.ReadLine()));
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


                        WriteList(Car.listOfCars, "Car", "mph");


                        if (inputString == "+")
                        {
                            AddVehicle(Car.listOfCars, "Car");
                            continue;
                        }

                        else
                        {
                            ShowSpecificVehicle(Car.listOfCars, "Car", "mph");

                            if (inputString == "-")
                            {
                                RemoveVehicle(Car.listOfCars, "Car", "mph");
                                continue;
                            }
                            else
                            {
                                ChangeSpeed(Car.listOfCars, "Car", "mph");
                                continue;

                            }



                        }

                        break;
                    case 2:
                        // skriver ut Listan Boats
                        break;
                    case 3:
                        // skriver ut listan Motorcyles
                        break;
                    case 4:
                        // skriver ut alla listor i m/s
                        break;
                    default:
                        break;

                }
            }

        }
        public static void WriteList(List<int> list, string vehicle, string speedUnit)
        {
            Console.WriteLine($"-- {list.Count} {vehicle}s in stock --");
            foreach (var i in list)
            {
                Console.WriteLine($"Car {list.IndexOf(i)} - {i} {speedUnit}");

            }
            Console.WriteLine($"----------------");
            Console.WriteLine($"Please select {vehicle} to change (0-{list.Count - 1}) or enter + to add a new {vehicle}");
            inputString = Console.ReadLine();
            Console.Clear();
        }

        public static void AddVehicle(List<int> list, string vehicle)
        {
            Car.listOfCars.Add(random.Next(10, 100));
            Console.WriteLine($"{vehicle} added, press any key to go back to main menu");
            Console.ReadKey();
            Console.Clear();
        }

        public static void ShowSpecificVehicle(List<int> list, string vehicle, string speedUnit)
        {
            input = int.Parse(inputString);
            i = input;

            Console.WriteLine("-- {0} {1} --", vehicle, list.IndexOf(i));
            Console.WriteLine($"Speed: {list[i]} {speedUnit}");
            Console.WriteLine("----------------");
            Console.WriteLine($"Please enter a new speed(0-100) or - to remove {vehicle}");
            inputString = Console.ReadLine();
            Console.Clear();
        }

        public static void RemoveVehicle(List<int> list, string vehicle, string speedUnit)
        {
            Car.listOfCars.Remove(list[i]);
            Console.WriteLine($"{vehicle} removed, press any key to go back to main menu");
            Console.ReadKey();
        }

        public static void ChangeSpeed(List<int> list, string vehicle, string speedUnit)
        {
            input = int.Parse(inputString);

            list[i] = input;


            Console.WriteLine("Car speed changed, press any key to go back to main menu");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
