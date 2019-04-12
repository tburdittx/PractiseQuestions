using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Microsoft.AspNetCore.Mvc;
using PracticeQuestions.Dal.Interface;

namespace PractiseQuestions.Services.Controllers
{
    [Route("api/[controller]")]
    public class CategoryController:ControllerBase
    {
        public ICategoryQueryRepository CategoryQueryRepository { get; }

        public CategoryController(ICategoryQueryRepository categoryQueryRepository)
        {
            CategoryQueryRepository = categoryQueryRepository;
        }

        [HttpGet("ReadAllCategories")]
        public Task<IEnumerable<Category>> ReadAllQuestions()

        {
            var result = this.CategoryQueryRepository.ReadAllAsync();
            return result;
        }
    }
}
