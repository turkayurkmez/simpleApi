using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using simpleApi.Models;
using simpleApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simpleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private FakeCategories categories;

        public CategoriesController(FakeCategories categories)
        {
            this.categories = categories;
        }
        [HttpGet]
        public IActionResult Get()
        {
         
            return Ok(categories);
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            categories.AddCategory(category);
            return Created("https://eklendi.com", category);
        }
    }
}
