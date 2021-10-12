using System;
using System.Collections.Generic;

namespace Labb2
{
    public class Motorcycle : Vehicle, IVehicle
    {
        
        public Motorcycle()
        {
            VehicleType = "Motorcycle";
            SpeedUnit = "km/h";
            Type = EVehicle.MOTORCYCLE;
        }

        
    }
}