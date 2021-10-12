using System;
using System.Collections.Generic;

namespace Labb2
{
    public class Car : Vehicle, IVehicle
    {
        //public List<int> listOfCars = new List<int>();

        public Car()
        {
            VehicleType = "Car";
            SpeedUnit = "mph";
            Type = EVehicle.CAR;
        }

        

        
    }
}