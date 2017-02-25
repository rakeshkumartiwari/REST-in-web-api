using System.Data.Entity;
using web_api_rest.Models;

namespace web_api_rest.Infrastructure
{
    public class EmployeeDb : DbContext
    {
        public EmployeeDb()
        {
           
        }

        public DbSet<Employee> Employees { get; set; }
    }
}