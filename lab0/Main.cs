// See https://aka.ms/new-console-template for more information

namespace TMPS_lab0;

class Lab1
{
    public static void Main()
    {
        ByAir byAir = new ByAir();
        ByWater byWater = new ByWater();
        SwitchVehicle switchVehicle = new SwitchVehicle(byAir, byWater);
        
        byAir.AvailableVehicles();
        byAir.Board("Plane");
        byAir.CalculateTax("Plane", 1000);
        byAir.Unboard("Plane");
        
        byWater.AvailableVehicles();
        byWater.Board("Boat");
        byWater.CalculateTax("Boat", 1000);
        switchVehicle.Switch(byWater);
        byWater.Unboard("Boat");

    }
}