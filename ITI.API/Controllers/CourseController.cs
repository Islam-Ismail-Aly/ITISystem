using ITI.BusnissLogicLayer.Dtos;
using ITI.BusnissLogicLayer.Services;
using Microsoft.AspNetCore.Mvc;

namespace ITI.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseController : Controller
    {

        [HttpGet]
        [Route("api/Course")]
        public IEnumerable<CourseDto> GetCourses()
        {
            return CourseService.GetCourses();
        }

        [HttpPost]
        [Route("CreateCourse")]
        public ActionResult<CourseDto> CreateCourse([FromForm] CourseDto course)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var createdCourse = CourseService.SaveCourse(course);

            if (createdCourse > 0) return Ok(course);

            return NotFound();
        }

        [HttpGet]
        [Route("GetCourse/{id}")]
        public ActionResult<CourseDto> GetCourse(int id)
        {
            if (id is 0) return BadRequest(ModelState);

            var course = TopicService.GetTopicById(id);

            if (course is not null) return NotFound(); // 404 Not Found

            return Ok(course); // 200 OK with course data
        }


    }
}
