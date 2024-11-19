using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [Route("Student/List")]
        [HttpGet]
        public String GetList()
        {
            return "Hi from Get List";
        }
        [Route("Student/id/{id}/city/{city}")]
        [HttpGet]
        public String GetStudentById(int id , string city)
        {
            return $"Hi from Get All Student: {id} coming form {city}";
        }
        [Route("Student/Get")]
        [HttpGet]
        public String SearchStudent([FromQuery] Student s)
        {
            return $"Data : {s.StudentId} {s.StudentName} {s.address} {s.Email}";
        }

    }
}
