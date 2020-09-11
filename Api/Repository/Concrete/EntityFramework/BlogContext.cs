

using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Repository.Concrete.EntityFramework
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options)
            :base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }


        
    }
}
