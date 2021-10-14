using System;

namespace VehicleClasses
{
    public class Boat : IVehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public Vehicle Type { get; set; }
        public double ConvertMS { get; set; }
        

        public static int Count = 0;

        public Boat()
        {
            Type = Vehicle.Boat;
            ConvertMS = 0.51;
        }
        public Boat(Random rnd, string name)
        {

            Count = Count + 1;
            Name = name;
            Type = Vehicle.Boat;
            Speed = rnd.Next(10, 100);
            ConvertMS = 0.51;

        }

        public int setSpeed(int newSpeed)
        {
            return Speed = newSpeed;
        }

        public int getSpeed()
        {
            return Speed;
        }
    }
}