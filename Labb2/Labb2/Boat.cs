﻿using System;
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
        public double SpeedMInS { get; set; }

        public static int Count = 0;

        public Boat(Random rnd, string name)
        {

            Count = Count + 1;
            Name = name;
            type = Vehicle.Boat;
            Speed = rnd.Next(10, 100);
            SpeedMInS = Speed * 0.51;

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