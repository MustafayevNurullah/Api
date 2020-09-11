using Api.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Repository.Concrete.EntityFramework
{
    public class EfUnitOfWork : IUnitOfWork
    {
        private readonly BlogContext dbcontext;

        public EfUnitOfWork(BlogContext blogContext)
        {
            dbcontext = blogContext;
        }

        public ICategoryRepository Category => new EfCategoryRepository(dbcontext);

        public ICommentRepository Comment => new EfCommentRepository(dbcontext);

        public IPostRepository Post => new EfPostRepository(dbcontext);

        public IUserRepository User => new EfUserRepository(dbcontext);

        public void Dispose()
        {
            dbcontext.Dispose();
        }
    }
}
