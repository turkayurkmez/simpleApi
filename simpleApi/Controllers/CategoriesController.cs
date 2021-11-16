using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using simpleApi.Models;
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
        [HttpGet]
        public IActionResult Get()
        {
            var categories = new List<Category>
            {
                new Category{ Id =1, Name ="Sağlık Bakanlığı"},
                new Category{ Id =2, Name ="Finans"},
                new Category{ Id =3, Name ="İletişim"},


            };
            return Ok(categories);
        }
    }
}
