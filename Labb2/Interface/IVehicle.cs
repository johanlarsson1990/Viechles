using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleClasses;

namespace Interface
{
    public interface IVehicle
    {
        string Name { get; set; }
        int Speed { get; set; }
        Vehicle Type { get; set; }
        double ConvertMS { get; set; }
        
        int setSpeed(int newSpeed);
        int getSpeed();

    }
}
