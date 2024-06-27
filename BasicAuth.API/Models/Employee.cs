namespace BasicAuth.API.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public bool IsActive { get; set; }

        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 1, FirstName = "John", LastName = "Doe", Gender = "Male", City = "New York", IsActive = true },
                new Employee { Id = 2, FirstName = "Jane", LastName = "Doe", Gender = "Female", City = "Los Angeles", IsActive = false },
                new Employee { Id = 3, FirstName = "Bob", LastName = "Smith", Gender = "Male", City = "Chicago", IsActive = true },
                new Employee { Id = 4, FirstName = "Sarah", LastName = "Johnson", Gender = "Female", City = "Houston", IsActive = false },
                new Employee { Id = 5, FirstName = "Mike", LastName = "Davis", Gender = "Male", City = "Philadelphia", IsActive = true },
            };
            return employees;
        }
    }
}