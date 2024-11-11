using Entities;
using Microsoft.AspNetCore.Mvc;
using Studio_Chen.Controllers;

namespace ControllerTests
{
    public class LessonControllerTest
    {
        [Fact]
        public void IsValidId()
        {
            var id = -1;
            var courseController = new CoursesController();
            var result = courseController.Get(id);
            Assert.NotNull(result);
        }
        [Fact]
        public void IsPost()
        {
            var course = new Course();
            var courseController = new CoursesController();
            var result = courseController.Post(course);
            Assert.IsType<OkObjectResult>(result);
        }
    }
}