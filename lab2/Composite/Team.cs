using System.Collections.Generic;

namespace Composite
{
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
}