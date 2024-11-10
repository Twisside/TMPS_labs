namespace TMPS_lab0;

public class SwitchVehicle
{
    public SwitchVehicle(ITravel currentVehicle, ITravel newVehicle)
    {
        this.CurrentVehicle = currentVehicle;
        this._newVehicle = newVehicle;
    }

    private ITravel CurrentVehicle { get; set; }
    private ITravel _newVehicle;
    
    public void Switch(ITravel newVehicle)
    {
        CurrentVehicle.Unboard(CurrentVehicle.ToString());
        _newVehicle.Board(_newVehicle.ToString());
    }
}