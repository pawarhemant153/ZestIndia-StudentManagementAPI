using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using StudentManagementAPI.Models;
using StudentManagementAPI.Services;
using Microsoft.AspNetCore.Authorization;

namespace StudentManagementAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _service;
        public StudentController(IStudentService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var data = _service.GetAll();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var data = _service.GetById(id);

            if(data == null)
                return NotFound();

            return Ok(data);
        }

        [HttpPost]
        public IActionResult Add(Student student)
        {
            _service.Add(student);
            return Ok("Student Added Successfully");
        }

        [HttpPut]
        public IActionResult Update(Student student)
        {
            _service.Update(student);
            return Ok("Student Updated Succesfully");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return Ok("Student Deleted Successfully");
        }
    }
}
