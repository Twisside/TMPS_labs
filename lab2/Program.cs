using System;
using Bridge;
using Composite;
using Decorator;

namespace DesignPatternsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bridge Pattern Usage
            var textNotification = new Notification(new TextMessage());
            textNotification.Notify("This is a text message");
            
            var emailNotification = new Notification(new EmailMessage());
            emailNotification.Notify("This is an email message");

            // Composite Pattern Usage
            var dev1 = new Developer { Name = "Dev1" };
            var dev2 = new Developer { Name = "Dev2" };
            var designer = new Designer { Name = "Designer1" };

            var team = new Team();
            team.AddEmployee(dev1);
            team.AddEmployee(dev2);
            team.AddEmployee(designer);

            team.ShowDetails();

            // Decorator Pattern Usage
            Coffee simpleCoffee = new SimpleCoffee();
            Console.WriteLine(simpleCoffee.GetDescription() + " $" + simpleCoffee.GetCost());

            Coffee milkCoffee = new MilkDecorator(simpleCoffee);
            Console.WriteLine(milkCoffee.GetDescription() + " $" + milkCoffee.GetCost());

            Coffee milkSugarCoffee = new SugarDecorator(milkCoffee);
            Console.WriteLine(milkSugarCoffee.GetDescription() + " $" + milkSugarCoffee.GetCost());
        }
    }
}