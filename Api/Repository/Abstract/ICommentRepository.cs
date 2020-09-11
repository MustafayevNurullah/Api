using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Repository.Abstract
{
  public  interface ICommentRepository
    {
        List<Comment> Comments(int PostId);
        void AddComment(Comment comment);
        void UpdateComment(Comment comment);
        void DeleteComment(int Id);
    }
}
