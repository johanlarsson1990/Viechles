using System;
using System.Collections.Generic;

namespace Labb2
{
    public class Motorcycle : Vehicle, IVehicle
    {
        
        public Motorcycle()
        {
            VehicleType = "Motorcycle";
            SpeedUnit = "km/h";
            VehicleList = new List<int>();
        }

        //public static List<int> listOfMotorcycles = new List<int>();
        public void CreateList(int input)
        {
            var random = new Random();

            for (int i = 0; i < input; i++)
            {
                VehicleList.Add(random.Next(10, 100));
            }
        }

        public void WriteList()
        {
            Console.WriteLine($"-- {VehicleList.Count} {VehicleType}s in stock --");
            foreach (var car in VehicleList)
            {
                Console.WriteLine($"{VehicleType} {VehicleList.IndexOf(car)} - {car} {SpeedUnit}");
            }

            Console.WriteLine($"----------------\n" +
                              $"Please select {VehicleType} to change (0-{VehicleList.Count - 1}) or enter + to add a new {VehicleType}.");
        }

        public void AddVehicle()
        {
            VehicleList.Add(new Random().Next(10, 100));
            Console.WriteLine($"{VehicleType} added, press any key to go back to main menu");
        }

        public void IndexedVehicle(int i)
        {
            Console.WriteLine($"-- {VehicleType} {VehicleList.IndexOf(i)} --\n" +
                              $"Speed: {VehicleList[i]} {SpeedUnit}");
            Console.WriteLine("----------------");
            Console.WriteLine($"Please enter a new speed(0-100) or - to remove {VehicleType}.");
        }

        public void RemoveVehicle(int i)
        {
            VehicleList.Remove(VehicleList[i]);
            Console.WriteLine($"{VehicleType} removed, press any key to go back to main menu.");
        }

        public void ChangeSpeed(int i)
        {
            VehicleList[i] = Speed;
            Console.WriteLine($"{VehicleType} speed changed, press any key to go back to main menu");
        }
    }
}