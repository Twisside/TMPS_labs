namespace TMPS_lab_1;

public interface ITravel
{
    public void AvailableVehicles();
    public void Board(string? vechicle);
    public void Unboard(string? vechicle);
    public void CalculateTax(string vechicle, int distance);
}