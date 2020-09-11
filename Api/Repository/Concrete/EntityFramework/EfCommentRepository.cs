using Api.Models;
using Api.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Repository.Concrete.EntityFramework
{
    public class EfCommentRepository : ICommentRepository
    {
        public BlogContext context;

        public EfCommentRepository(BlogContext blogContext)
        {
            context = blogContext;
        }

        public void AddComment(Comment comment)
        {
            context.Add(comment);
        }

        public List<Comment> Comments(int PostId)
        {
            return context.Comments.Where(x => x.PostId == PostId).ToList();
        }

        public void DeleteComment(int Id)
        {
            context.Remove(context.Comments.Where(x=> x.Id==Id));
        }

        public void UpdateComment(Comment comment)
        {
            context.Update(comment);
        }
    }
}
