using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Labb2
{
    public class Car : IVehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public Vehicle type { get; set; }
        public static int Count = 0;
        private RandomName nameHelper = new RandomName();
        public Car(Random rnd)
        {

            Count = Count + 1;
            Name = nameHelper.randomName(rnd);
            type = Vehicle.Car;
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

         //public static List<int> listOfCars = new List<int>();

         //public static void CreateList(int input)
         //{

         //    var random = new Random();

            var random = new Random();


         //    for (int i = 0; i < input; i++)
         //    {

         //        listOfCars.Add(random.Next(10, 100));

         //    }
         //}

            }
        }
    }
}