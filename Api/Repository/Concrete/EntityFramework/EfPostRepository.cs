using Api.Models;
using Api.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Repository.Concrete.EntityFramework
{
    public class EfPostRepository : IPostRepository
    {

        public BlogContext context;

        public EfPostRepository(BlogContext blogContext)
        {
            context = blogContext;
        }

        public void AddPost(Post post)
        {
            context.Add(post);
        }

        public void DeletePost(int Id)
        {
            context.Remove(context.Posts.Where(x=> x.Id==Id));
        }

        public List<Post> Post(int CategoryId)
        {
            return context.Posts.Where(x => x.CategoryId == CategoryId).ToList();
        }

        public void UpdatePost(Post post)
        {
            context.Posts.Update(post);
        }
    }
}
