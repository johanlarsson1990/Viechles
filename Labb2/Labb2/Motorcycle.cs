using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2
{
    public class Motorcycle : IVehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public Vehicle type { get; set; }
        public static int Count = 0;
        public Motorcycle(Random rnd)
        {
            Count = Count + 1;
            Name = Vehicle.Motorcycle + " " + Count;
            type = Vehicle.Motorcycle;
            Speed = rnd.Next(10, 100);
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