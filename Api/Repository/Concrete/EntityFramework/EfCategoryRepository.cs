using Api.Models;
using Api.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Repository.Concrete.EntityFramework
{
    public class EfCategoryRepository : ICategoryRepository
    {
        public BlogContext context;

        public EfCategoryRepository(BlogContext blogContext)
        {
            context = blogContext;
        }

        public void AddCategory(Category category)
        {
            context.Add(category);
        }

        public List<Category> Categories()
        {
            return context.Categories.ToList();
        }

        

        public void DeleteCategory(int Id)
        {
            context.Remove(context.Categories.Where(x => x.Id == Id));
        }

        public void UpdateCategory(Category category)
        {
            context.Update(category);
        }
    }
}
