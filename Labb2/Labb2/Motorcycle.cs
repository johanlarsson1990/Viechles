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
            Speed = SetSpeed(rnd);
        }
        public int SetSpeed(Random rnd)
        {
            return rnd.Next(10, 100);
        }

        //public static List<int> listOfMotorcycles = new List<int>();
        //public static void CreateList(int input)
        //{

        //    var random = new Random();

        //    for (int i = 0; i < input; i++)
        //    {
        //        listOfMotorcycles.Add(random.Next(10, 100));
        //    }
        //}
    }
}
