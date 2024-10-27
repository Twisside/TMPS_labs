namespace TMPS_lab_1;

public class ByLand : ITravel
{
    private static List<string> _vechicles = new List<string>() { "Car", "Bike", "Bus", "Truck", "Train" };
    public static int _distance { get; set; }

    public void AvailableVehicles()
    {
        Console.WriteLine("Available vehicles for land transportation: ");
        foreach (var vechicle in _vechicles)
        {
            Console.WriteLine(vechicle);
        }
    }

    public void Board(string? vechicle)
    {
        Console.WriteLine("Boarding the " + vechicle);
    }
    
    public void Unboard(string? vechicle)
    {
        Console.WriteLine("Unboarding the " + vechicle);
    }
    
    public void CalculateTax(string vechicle, int distance)
    {
        Console.WriteLine("The tax for traveling by " + vechicle + " for " + distance + " km is " + distance * 0.1 + " $");
    }

}