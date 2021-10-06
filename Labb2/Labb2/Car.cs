using System;
using System.Collections.Generic;

namespace Labb2
{
    public class Car
    {
        public int Speed { get; set; }


        public static List<int> listOfCars = new List<int>();


        public Car()
        {

        }

        public static void CreateList(int input)
        {

            var random = new Random();



            for (int i = 0; i < input; i++)
            {

                listOfCars.Add(random.Next(10, 100));

            }
        }
    }
}
