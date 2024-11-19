using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public EmployeeController() { }
        [Route("Name")]
        [HttpGet]
        public String GetName()
        {
            return "Return Name";
        }
        [Route("Details")]
        [HttpGet]
        public Employee GetEmployee()
        {
            return new Employee() { EmployeeId= 1 , Name = "Anup" , Age = 22 , Email = "avsdg" , Gender = "Male" };
        }
        [Route("GetAll")]
        [HttpGet]
        public IEnumerable<Employee> GetEmployeeList()
        {
            return new List<Employee>()
            {
             new Employee { EmployeeId= 1 , Name = "Anup" , Age = 22 , Email = "avsdg" , Gender = "Male" },
             new Employee { EmployeeId= 2 , Name = "Bnup" , Age = 23 , Email = "avsdg" , Gender = "Male" },
             new Employee { EmployeeId= 3 , Name = "Cnup" , Age = 24 , Email = "avsdg" , Gender = "Male" },
            };
        }
       
        

    }
}
