using System;


namespace VehicleClasses
{
    public class Motorcycle : IVehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public Vehicle Type { get; set; }
        public double ConvertMS { get; set; }
        


        public static int Count = 0;

        public Motorcycle()
        {
            Type = Vehicle.Motorcycle;
            ConvertMS = 0.28;
        }
        public Motorcycle(Random rnd, string name)
        {
            Count = Count + 1;
            Name = name;
            Type = Vehicle.Motorcycle;
            Speed = rnd.Next(10, 100);
            ConvertMS = 0.28; 
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