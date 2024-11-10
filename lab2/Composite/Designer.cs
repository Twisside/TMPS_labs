namespace Composite
{
    public class Designer : Employee
    {
        public override void ShowDetails()
        {
            Console.WriteLine("Designer: " + Name);
        }
    }
}