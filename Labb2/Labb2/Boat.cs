using System;
using System.Collections.Generic;

namespace Labb2
{
    public class Boat : Vehicle, IVehicle
    {
        public List<int> listOfBoats = new List<int>();

        public Boat()
        {
            VehicleType = "Boat";
            SpeedUnit = "knots";
            Type = EVehicle.BOAT;
        }

        

    }
}