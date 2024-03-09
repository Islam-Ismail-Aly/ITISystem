using ITI.BusnissLogicLayer.Dtos;
using ITI.BusnissLogicLayer.Services;
using Microsoft.AspNetCore.Mvc;

namespace ITI.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TopicController : Controller
    {
        [HttpGet]
        [Route("GetTopic/{id}")]
        public ActionResult<TopicDto> GetCourse(int id)
        {
            if (id is 0) return BadRequest(ModelState);

            var course = TopicService.GetTopicById(id);

            if (course is not null) return NotFound(); // 404 Not Found

            return Ok(course); // 200 OK with course data
        }
    }
}
