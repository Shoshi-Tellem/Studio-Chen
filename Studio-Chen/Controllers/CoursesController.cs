using Entities;
using Microsoft.AspNetCore.Mvc;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Studio_Chen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private IEnumerable<Course> courses;
        // GET: api/<CoursesController>
        [HttpGet]
        public IEnumerable<Course> Get()
        {
            return courses;
        }

        // GET api/<CoursesController>/5
        [HttpGet("{id}")]
        public Course Get(int id)
        {
            try
            {
                return courses.First(c => c.Identity == id);
            }
            catch (Exception ex){
                throw new Exception("the id isnot valid");
            }
        }

        // POST api/<CoursesController>
        [HttpPost]
        public OkObjectResult Post([FromBody] Course course)
        {
            return Ok(courses = courses.Concat(new List<Course> { course }));
        }

        // PUT api/<CoursesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Course uptatedCourse)
        {
             //int index = courses.(c => c.Identity == id);
             //courses[index] = updatedCourse;
        }

        // DELETE api/<CoursesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            courses=courses.Where(c => c.Identity != id);
        }
    }
}
