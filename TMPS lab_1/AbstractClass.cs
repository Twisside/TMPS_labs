namespace TMPS_lab_1;


// Abstract Product
abstract class Vehicle {
    public abstract void DisplayInfo();
}

// Abstract Factory
abstract class VehicleFactory {
    public abstract Vehicle CreateVehicle();
}

// Builder Interface
interface IVehicleBuilder {
    void SetEngine(string engine);
    void SetColor(string color);
    void SetSeats(int seats);
    Vehicle GetVehicle();
}

// Prototype Interface
interface IVehiclePrototype {
    public IVehiclePrototype Clone();
}
    