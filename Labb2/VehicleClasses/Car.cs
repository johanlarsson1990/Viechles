using System;


namespace VehicleClasses
{
    public class Car : IVehicle
    {
        public string Name { get; set; } 
        public int Speed { get; set; }
        public Vehicle Type { get; set; }
        public double ConvertMS { get; set; }
        

        public static int Count = 0;

        public Car()
        {
            Type = Vehicle.Car;
            ConvertMS = 0.45;
        }
        public Car(Random rnd, string name)
        {

            Count = Count + 1;
            Name = name;
            Type = Vehicle.Car;
            Speed = rnd.Next(10, 100);
            ConvertMS = 0.45;
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