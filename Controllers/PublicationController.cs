using Microsoft.AspNetCore.Mvc;
using BackChat.Services;
using BackChat.Models;
    
namespace BackChat.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PublicationController : ControllerBase
    {

        PublicationService publicationService = new PublicationService();

        [HttpPost("create")]
        public IActionResult AddPublication([FromForm] Publication publication)
        {
            publicationService.addPublication(publication);
            return Redirect("http://localhost:5128");

        }

        [HttpGet("all")]
        public IActionResult getPublications(){
            var all = publicationService.getPublications();
            return Ok(all);
        }

    }
}
