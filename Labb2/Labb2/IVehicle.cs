using System;
using System.Collections.Generic;

namespace Labb2
{
    public interface IVehicle
    {
        int Speed { get; set; }
        string VehicleType { get; set; }
        string SpeedUnit { get; set; }
        List<int> VehicleList { get; set; }

        void CreateList(int input);
        void WriteList();
        void AddVehicle();
        void IndexedVehicle(int i);
        void RemoveVehicle(int i);
        void ChangeSpeed(int i);
        

    }
}