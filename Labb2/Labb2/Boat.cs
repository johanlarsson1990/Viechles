using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2
{
    public class Boat : IVehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public Vehicle type { get; set; }
        public static int Count = 0;
        
        public Boat()
        {
            Random rnd = new Random();
            Count = Count + 1;
            Name = Vehicle.Boat + " " + Count;
            type = Vehicle.Boat;
            Speed = rnd.Next(10, 100);
        }

        public int setSpeed(int newspeed)
        {
            return Speed = newspeed;
        }
        public int getSpeed()
        {
            return Speed;
        }
        // public static List<int> listOfBoats = new List<int>();

        //public static void CreateList(int input)
        //{

        //    var random = new Random();

        //    for (int i = 0; i < input; i++)
        //    {
        //        listOfBoats.Add(random.Next(10, 100));
        //    }
        //}
    }
}
