namespace TMPS_lab_1;


// Concrete Products
class Car : Vehicle {
    public override void DisplayInfo() => Console.WriteLine("This is a Car.");
}

class Bike : Vehicle {
    public override void DisplayInfo() => Console.WriteLine("This is a Bike.");
}

// Concrete Factory Implementations
class CarFactory : VehicleFactory {
    public override Vehicle CreateVehicle() => new Car();
}

class BikeFactory : VehicleFactory {
    public override Vehicle CreateVehicle() => new Bike();
}

// Concrete Builder for Custom Cars
class CustomCar : Vehicle, IVehiclePrototype {
    public string Engine { get; set; }
    public string Color { get; set; }
    public int Seats { get; set; }

    public override void DisplayInfo() {
        Console.WriteLine($"Custom Car -> Engine: {Engine}, Color: {Color}, Seats: {Seats}");
    }

    // Implement the Prototype Clone Method
    public IVehiclePrototype Clone() {
        return new CustomCar {
            Engine = Engine,
            Color = Color,
            Seats = Seats
        };
    }
}

// Concrete Builder Implementation
class CarBuilder : IVehicleBuilder {
    private CustomCar _car = new CustomCar();

    public void SetEngine(string engine) => _car.Engine = engine;
    public void SetColor(string color) => _car.Color = color;
    public void SetSeats(int seats) => _car.Seats = seats;
    public Vehicle GetVehicle() => _car;
}

// Director for Building Vehicles
class VehicleDirector {
    public Vehicle Construct(IVehicleBuilder builder) {
        builder.SetEngine("V8");
        builder.SetColor("Red");
        builder.SetSeats(4);
        return builder.GetVehicle();
    }
}