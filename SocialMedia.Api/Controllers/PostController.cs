using Microsoft.AspNetCore.Mvc;
using SocialMedia.Infrastructure.Repositories;
using System.Collections.Generic;

namespace SocialMedia.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetPosts()
        {
            IEnumerable<Core.Entities.Post> post = new PostRepository().GetPost();
            return Ok(post);
        }
    }
}
