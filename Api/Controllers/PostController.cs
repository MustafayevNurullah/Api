using Api.Models;
using Api.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    [Route("[api/controller]")]
    public class PostController : ControllerBase
    {
        IPostRepository postRepository;

        public PostController(IPostRepository postRepository)
        {
            this.postRepository = postRepository;
        }
        [HttpGet("{Id}")]
        public async Task<IEnumerable<Post>> Posts(int Id)
        {
            return postRepository.Post(Id);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Post post)
        {
            postRepository.AddPost(post);

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePost(int Id)
        {
            postRepository.DeletePost(Id);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdatePost(Post post)
        {
            postRepository.UpdatePost(post);
            return Ok();
        }
    }
}
