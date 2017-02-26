using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web.Services.Description;
using web_api_rest.Models;

namespace web_api_rest.Infrastructure
{
    public class EmployeeRepository
    {
        private readonly EmployeeDb _db;
        public EmployeeRepository()
        {
            _db=new EmployeeDb();
        }
        public void SaveEmployee(Employee employee)
        {
            _db.Employees.Add(employee);
            _db.SaveChanges();
        }

        public Employee GetEmployee(int id)
        {
            try
            {
                return _db.Employees.Single(e => e.Id == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            
        }

        public void Update(Employee employeeToUpdate)
        {
            var employee = GetEmployee(employeeToUpdate.Id);
            employee.Name = employeeToUpdate.Name;
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var employee = GetEmployee(id);
            _db.Employees.Remove(employee);
            _db.SaveChanges();
        }
    }
}