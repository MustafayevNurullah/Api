using Api.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Repository.Concrete.EntityFramework
{
    public class EfUserRepository : IUserRepository
    {


        public BlogContext context;

        public EfUserRepository(BlogContext blogContext)
        {
            context = blogContext;
        }

        public void AddUser(User user)
        {
            
            context.Users.Add(user);
            context.SaveChanges();
            
        }

        public User GetUser(string Email)
        {
            return context.Users.Where(x => x.Email == Email).FirstOrDefault();
        }

        public List<User> Users(int CommentId)
        {
            return context.Users.Where(x => x.Id == CommentId).ToList();
        }
    }
}
