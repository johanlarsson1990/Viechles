using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2
{
    public class Motorcycle
    {
        public int Speed { get; set; }

        public Motorcycle(int speed)
        {
            Speed = speed;
        }

        public static List<int> listOfMotorcycles = new List<int>();
        public static void CreateList(int input)
        {

            var random = new Random();

            for (int i = 0; i < input; i++)
            {
                listOfMotorcycles.Add(random.Next(10, 100));
            }
        }
    }
}
