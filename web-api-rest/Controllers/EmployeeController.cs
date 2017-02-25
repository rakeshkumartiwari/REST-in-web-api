using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using web_api_rest.Infrastructure;
using web_api_rest.Models;


namespace web_api_rest.Controllers
{
    public class EmployeeController : ApiController
    {

        public EmployeeRepository EmployeeRepository { get; set; }

        public EmployeeController()
        {
            EmployeeRepository = new EmployeeRepository();
        }
        
        public Employee Get(int id)
        {
            return EmployeeRepository.GetEmployee(id);
        }
        public void Post(Employee employee)
        {
            EmployeeRepository.SaveEmployee(employee);
        }
        
        public void Put(Employee employee)
        {
            EmployeeRepository.Update(employee);
        }
        public void Delete(int id)
        {
            EmployeeRepository.Delete(id);
        }
    }
}
