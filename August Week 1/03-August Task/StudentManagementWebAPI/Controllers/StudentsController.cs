using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace StudentManagementWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private static List<Student> studentInfo = new List<Student>();

        [HttpGet]
        public IActionResult GetAllStudents()
        {
            return Ok(studentInfo);
        }

        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            foreach(Student st in studentInfo)
            {
                if(st.Id==id){
                    return Ok(st);
                }
            
            }
            return NotFound("Student with the given ID not found.");
        }

        [HttpPost]
        public IActionResult AddStudent([FromBody] Student st)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            studentInfo.Add(st);
            return CreatedAtAction(nameof(GetStudentById), new{id=st.Id}, st);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudentInfo(int id, [FromBody] Student updatedStudent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            foreach(Student st in studentInfo)
            {
                if(st.Id==id){
                    st.Name = updatedStudent.Name;
                    st.Email = updatedStudent.Email;
                    st.Course = updatedStudent.Course;
                    st.Age = updatedStudent.Age;
                    return Ok(st);
                }
            }
            return NotFound("Student with the given ID not found.");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            foreach(Student st in studentInfo)
            {
                if(st.Id==id){
                    studentInfo.Remove(st);
                    return Ok("Student with the given ID has been deleted.");
                }
            }
            return NotFound("Student with the given ID not found.");
        }




    }
}