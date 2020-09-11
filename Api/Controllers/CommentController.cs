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
    public class CommentController:ControllerBase
    {
        ICommentRepository commentRepository;

        public CommentController(ICommentRepository commentRepository)
        {
            this.commentRepository = commentRepository;
        }
        [HttpGet("{Id}")]
        public async Task<IEnumerable<Comment>> Comments(int Id)
        {
            return commentRepository.Comments(Id);
        }
        [HttpPost]
        public async Task<IActionResult> AddComment(Comment comment)
        {
            commentRepository.AddComment(comment);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteComment(int Id)
        {
            commentRepository.DeleteComment(Id);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateComment(Comment post)
        {
            commentRepository.UpdateComment(post);
            return Ok();
        }

       
    }
}
