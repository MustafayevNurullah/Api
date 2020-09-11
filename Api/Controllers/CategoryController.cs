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
    public class CategoryController:ControllerBase
    {
        ICategoryRepository categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        [HttpGet]

        public async Task<IEnumerable<Category>> Categories()
        {

            return categoryRepository.Categories();

        }
    }
}
