using System;
using System.Collections.Generic;

namespace Labb2
{
    public class Boat
    {
        public int Speed { get; set; }

        public Boat(int speed)
        {
            Speed = speed;
        }

        public static List<int> listOfBoats = new List<int>();

        public static void CreateList(int input)
        {

            var random = new Random();

            for (int i = 0; i < input; i++)
            {
                listOfBoats.Add(random.Next(10, 100));
            }
        }
    }
}
