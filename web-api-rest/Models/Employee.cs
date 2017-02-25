using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web_api_rest.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get;  set; }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Employee()
        {
                
        }
    }
}