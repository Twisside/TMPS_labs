namespace Composite
{
    public class Developer : Employee
    {
        public override void ShowDetails()
        {
            Console.WriteLine("Developer: " + Name);
        }
    }
}