namespace TMPS_lab_1;

public class Lab1
{
    static void Main()
    {

        // 1. Factory Method Usage
        Console.WriteLine("Factory Method Pattern:");
        VehicleFactory carFactory = new CarFactory();
        Vehicle car = carFactory.CreateVehicle();
        car.DisplayInfo();

        VehicleFactory bikeFactory = new BikeFactory();
        Vehicle bike = bikeFactory.CreateVehicle();
        bike.DisplayInfo();

        // 2. Builder Pattern Usage
        Console.WriteLine("\nBuilder Pattern:");
        IVehicleBuilder carBuilder = new CarBuilder();
        VehicleDirector director = new VehicleDirector();
        Vehicle customCar = director.Construct(carBuilder);
        customCar.DisplayInfo();

        // 3. Prototype Pattern Usage
        Console.WriteLine("\nPrototype Pattern:");
        CustomCar prototypeCar = new CustomCar {
            Engine = "Electric",
            Color = "Blue",
            Seats = 2
        };

        CustomCar clonedCar = (CustomCar)prototypeCar.Clone();
        clonedCar.DisplayInfo();
    }
}