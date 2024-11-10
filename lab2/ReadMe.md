# Structural Design Patterns

## Author: Timciuc Ana-Maria

----

## Objectives:

* Get familiar with the Structural Design Patterns;
* Choose a specific domain;
* Implement at least 3 Structural Design Patterns for the specific domain;

## Used Design Patterns:

* Bridge
* Composite
* Decorator

## Implementation

* This project demonstrates the implementation of three structural design patterns: Bridge, Composite, and Decorator. These patterns make it easier to separate abstractions from implementations, handle compositions and individual objects consistently, and dynamically give objects behavior.

### Bridge Pattern
The Bridge pattern is used to decouple an abstraction from its implementation so that the two can vary independently.

```csharp
public class Notification
{
    private readonly IMessageSender _messageSender;

    public Notification(IMessageSender messageSender)
    {
        _messageSender = messageSender;
    }

    public void Notify(string message)
    {
        _messageSender.SendMessage(message);
    }
}
```

### Composite Pattern
The Composite pattern is used to treat individual objects and compositions of objects uniformly.

```csharp
public class Team : Employee
{
    private readonly List<Employee> _employees = new List<Employee>();

    public void AddEmployee(Employee employee)
    {
        _employees.Add(employee);
    }

    public void RemoveEmployee(Employee employee)
    {
        _employees.Remove(employee);
    }

    public override void ShowDetails()
    {
        foreach (var employee in _employees)
        {
            employee.ShowDetails();
        }
    }
}
```

### Decorator Pattern
The Decorator pattern allows behavior to be added to an individual object, dynamically, without affecting the behavior of other objects from the same class.

```csharp
public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(Coffee coffee) : base(coffee) { }

    public override string GetDescription()
    {
        return _coffee.GetDescription() + ", Milk";
    }

    public override double GetCost()
    {
        return _coffee.GetCost() + 1.5;
    }
}
```

## Conclusions / Screenshots / Results

In short, the project demonstrated the Bridge, Composite, and Decorator patterns effectively. We separated concerns, treated objects uniformly, and added behavior dynamically. The code is modular, robust, and easy to expand.

![Screenshot (136).png](Screenshot%20%28136%29.png)