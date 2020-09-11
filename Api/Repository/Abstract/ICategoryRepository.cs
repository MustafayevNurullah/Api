using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Repository.Abstract
{
   public interface ICategoryRepository
    {
        List<Category> Categories();
        void AddCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(int Id);
    }
}
