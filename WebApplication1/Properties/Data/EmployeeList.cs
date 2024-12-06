namespace WebApplication1.Properties.Data
{
    public class EmployeeList
    {
        public int Id { get; set; }
        public IList<Employee> Employees { get; set; }

        public EmployeeList()
        {
            Employees = new List<Employee>(); // Initialize the Employees list
        }
    }
}
