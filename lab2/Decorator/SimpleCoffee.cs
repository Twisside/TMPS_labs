namespace Decorator
{
    public class SimpleCoffee : Coffee
    {
        public override string GetDescription()
        {
            return "Simple Coffee";
        }

        public override double GetCost()
        {
            return 5.0;
        }
    }
}