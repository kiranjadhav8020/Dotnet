using CurdOperation_RestAPI.Models;
using CurdOperation_RestAPI.Service;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CurdOperation_RestAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentClass : ControllerBase
    {

        private readonly IStudentService _studentService;

        public StudentClass(IStudentService studentService)
        {
            this._studentService = studentService;
        }

        [HttpGet("getAllStudent")]
        public ActionResult<List<Student>> getAll()
        {
            Console.WriteLine("GET ALL");
            List<Student> result = _studentService.GetAllStudent();
            if (result != null)
            {
                return result;
            }
            return NotFound();
        }

        [HttpGet("getStudentById/{id}")]
        public ActionResult<Student> GetStudentById([FromRoute] int id)
        {
            Console.WriteLine("GET BY ID");

            Student result = _studentService.GetStudentById(id);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost("createStudent")]
        public ActionResult<Student> CreatStudent(Student std)
        {
            Console.WriteLine("CREATE STUDENT");

            if (std != null)
            {
                Student result = _studentService.CreateNewStudent(std);
                if (result != null)
                {
                    return result;
                }
            }

            return NotFound();

        }

        [HttpPut("updateStudent")]
        public ActionResult<Student> UpdateStudent(Student student)
        {
            Console.WriteLine("UPDATE STUDENT");

            if (student != null)
            {
                Student result=_studentService.UpdateStudent(student);
                if (result != null)
                {
                    return result;
                } 
            }

            return NotFound();
        }

        [HttpDelete("deleteStudentById")]
        public ActionResult<Student> DeleteStudent(int id)
        {
            Console.WriteLine("DELETE STUDENT ");

            if (id != null)
            {
                Student result=_studentService.DeleteStudent(id);
                if (result != null)
                    return result;
            }
            return NotFound();
        }



    }

 
}
