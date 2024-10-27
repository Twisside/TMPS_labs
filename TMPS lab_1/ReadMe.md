# Vehicle Manufacturing System - Creational Design Patterns in C#

## Introduction
This project demonstrates the implementation of three creational design patterns in C#: **Factory Method**, **Builder**, and **Prototype**. The domain chosen is a **Vehicle Manufacturing System**, where different types of vehicles are created, customized, and cloned using appropriate design patterns.

## Task Breakdown

### 1. Domain Selection: Vehicle Manufacturing System
- **Objective**: Create a system capable of handling the creation, customization, and cloning of different types of vehicles, such as cars and bikes.
- **Reason for Choice**: The system involves frequent and varied object creation, making it suitable for demonstrating creational design patterns.

### 2. Main Classes and Instantiation Mechanisms
- **Key Classes**:
    - `Vehicle`: Abstract base class for all vehicles.
    - `Car`, `Bike`: Concrete vehicle classes derived from `Vehicle`.
    - `VehicleFactory`: Abstract factory for creating vehicles.
    - `CarFactory`, `BikeFactory`: Concrete factories for creating specific vehicle types.
    - `IVehicleBuilder`, `CarBuilder`: Builder interface and concrete builder for customizing cars.
    - `VehicleDirector`: Directs the building process for vehicles.
    - `VehiclePrototype`, `CustomCar`: Interface and concrete class for cloning vehicle objects.

### 3. Implementation of Creational Design Patterns

#### 3.1 Factory Method Pattern
- **Objective**: Encapsulate the creation of `Vehicle` objects, allowing easy extension for additional vehicle types.
- **Classes Involved**:
    - `VehicleFactory` (Abstract Creator)
    - `CarFactory`, `BikeFactory` (Concrete Creators)
    - `Vehicle` (Abstract Product)
    - `Car`, `Bike` (Concrete Products)
- **Code**:
  ```csharp
  // Example Usage:
  VehicleFactory carFactory = new CarFactory();
  Vehicle car = carFactory.CreateVehicle();
  car.DisplayInfo();  // Output: "This is a Car."
  ```
- **Benefits**: Simplifies object creation and supports the Open/Closed Principle by allowing new vehicle types to be added without modifying existing code.

#### 3.2 Builder Pattern
- **Objective**: Create complex vehicle objects step-by-step, allowing customization of properties such as engine, color, and seats.
- **Classes Involved**:
    - `IVehicleBuilder` (Builder Interface)
    - `CarBuilder` (Concrete Builder)
    - `CustomCar` (Product)
    - `VehicleDirector` (Director)
- **Code**:
  ```csharp
  // Example Usage:
  IVehicleBuilder carBuilder = new CarBuilder();
  VehicleDirector director = new VehicleDirector();
  Vehicle customCar = director.Construct(carBuilder);
  customCar.DisplayInfo();  // Output: "Custom Car -> Engine: V8, Color: Red, Seats: 4"
  ```
- **Benefits**: Separates the construction logic from the representation, enabling the creation of different variations of `CustomCar` objects using the same process.

#### 3.3 Prototype Pattern
- **Objective**: Clone existing vehicle objects to create new instances, saving resources when creating objects with pre-defined configurations.
- **Classes Involved**:
    - `VehiclePrototype` (Prototype Interface)
    - `CustomCar` (Concrete Prototype)
- **Code**:
  ```csharp
  // Example Usage:
  CustomCar prototypeCar = new CustomCar { Engine = "Electric", Color = "Blue", Seats = 2 };
  CustomCar clonedCar = (CustomCar)prototypeCar.Clone();
  clonedCar.DisplayInfo();  // Output: "Custom Car -> Engine: Electric, Color: Blue, Seats: 2"
  ```
- **Benefits**: Enables efficient object creation by cloning, particularly useful when object instantiation is resource-intensive.

### 4. Full Code Implementation
```csharp
// Abstract Classes and Interfaces

abstract class Vehicle {
    public abstract void DisplayInfo();
}

abstract class VehicleFactory {
    public abstract Vehicle CreateVehicle();
}

interface IVehicleBuilder {
    void SetEngine(string engine);
    void SetColor(string color);
    void SetSeats(int seats);
    Vehicle GetVehicle();
}

abstract class VehiclePrototype {
    public abstract VehiclePrototype Clone();
}

// Concrete Implementations

class Car : Vehicle {
    public override void DisplayInfo() => Console.WriteLine("This is a Car.");
}

class Bike : Vehicle {
    public override void DisplayInfo() => Console.WriteLine("This is a Bike.");
}

class CarFactory : VehicleFactory {
    public override Vehicle CreateVehicle() => new Car();
}

class BikeFactory : VehicleFactory {
    public override Vehicle CreateVehicle() => new Bike();
}

class CustomCar : Vehicle, VehiclePrototype {
    public string Engine { get; set; }
    public string Color { get; set; }
    public int Seats { get; set; }

    public override void DisplayInfo() {
        Console.WriteLine($"Custom Car -> Engine: {Engine}, Color: {Color}, Seats: {Seats}");
    }

    public override VehiclePrototype Clone() {
        return new CustomCar {
            Engine = this.Engine,
            Color = this.Color,
            Seats = this.Seats
        };
    }
}

class CarBuilder : IVehicleBuilder {
    private CustomCar _car = new CustomCar();

    public void SetEngine(string engine) => _car.Engine = engine;
    public void SetColor(string color) => _car.Color = color;
    public void SetSeats(int seats) => _car.Seats = seats;
    public Vehicle GetVehicle() => _car;
}

class VehicleDirector {
    public Vehicle Construct(IVehicleBuilder builder) {
        builder.SetEngine("V8");
        builder.SetColor("Red");
        builder.SetSeats(4);
        return builder.GetVehicle();
    }
}

// Main Program

class Program {
    static void Main() {
        Console.WriteLine("Factory Method Pattern:");
        VehicleFactory carFactory = new CarFactory();
        Vehicle car = carFactory.CreateVehicle();
        car.DisplayInfo();

        VehicleFactory bikeFactory = new BikeFactory();
        Vehicle bike = bikeFactory.CreateVehicle();
        bike.DisplayInfo();

        Console.WriteLine("\nBuilder Pattern:");
        IVehicleBuilder carBuilder = new CarBuilder();
        VehicleDirector director = new VehicleDirector();
        Vehicle customCar = director.Construct(carBuilder);
        customCar.DisplayInfo();

        Console.WriteLine("\nPrototype Pattern:");
        CustomCar prototypeCar = new CustomCar { Engine = "Electric", Color = "Blue", Seats = 2 };
        CustomCar clonedCar = (CustomCar)prototypeCar.Clone();
        clonedCar.DisplayInfo();
    }
}
```

### 5. Benefits of the Implementation
- **Separation of Concerns**: Each pattern encapsulates a different aspect of object creation, making the system modular and extensible.
- **Scalability**: New vehicle types, configurations, or cloning mechanisms can be added without significant changes to existing code.
- **Reusability**: Components like the `VehicleDirector` and `CustomCar` can be reused across different projects that require similar patterns.

## Conclusion
This project demonstrates the practical implementation of three core creational design patterns in C#: Factory Method, Builder, and Prototype. These patterns work together to manage object creation efficiently and flexibly, supporting clean code practices and extensible design.
