namespace VehicleClasses
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
