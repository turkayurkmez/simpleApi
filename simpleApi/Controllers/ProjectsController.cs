using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using simpleApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task = simpleApi.Models.Task;

namespace simpleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {

        private List<Project> projects = null;
        public ProjectsController()
        {
            projects = new List<Project>
            {
                new Project {
                    CategoryId=1, Name="Genel Sağlık Uygulamaları", Description="bla bla", Id=1, Tasks=new List<Task>{ new Task {
                        Id=1,
                        Name="veritabanı konfigürasyonu",
                        Description="Test",
                        ExpectedDate=DateTime.Now.AddDays(18),
                        IsDone=false},

                        new Task {
                        Id=2,
                        Name="authentication işlemleri",
                        Description="Test",
                        ExpectedDate=DateTime.Now.AddDays(35),
                        IsDone=false},


                    }},
                 new Project {
                    CategoryId=2, Name="Bankacılık", Description="bla bla", Id=2, Tasks=new List<Task>{ new Task {
                        Id=3,
                        Name="BDD altyapısı oluşturulacak",
                        Description="Test",
                        ExpectedDate=DateTime.Now.AddMonths(1),
                        IsDone=false},

                        new Task {
                        Id=4,
                        Name="Test case'leri yazılacak",
                        Description="Test",
                        ExpectedDate=DateTime.Now.AddMonths(2),
                        IsDone=false},


                    }},
                  new Project {
                    CategoryId=1, Name="Devlet hastaneleri otomasyou", Description="bla bla", Id=1, Tasks=new List<Task>{ new Task {
                        Id=5,
                        Name="Proje altapısı",
                        Description="Test",
                        ExpectedDate=DateTime.Now.AddDays(18),
                        IsDone=false},

                        new Task {
                        Id=6,
                        Name="Devops mimarisi",
                        Description="Test",
                        ExpectedDate=DateTime.Now.AddDays(35),
                        IsDone=false},

                        new Task {
                        Id=7,
                        Name="Jenkin pipeline'ı",
                        Description="Test",
                        ExpectedDate=DateTime.Now.AddDays(35),
                        IsDone=false}


                    }}
            };
        }
        [HttpGet]
        public IActionResult Get()
        {

            return Ok(projects);
        }
        [HttpGet("{id}")]
        public IActionResult GetByCategory(int id)
        {
            var result = this.projects.Where(p => p.CategoryId == id);
            return Ok(result);
        }
        [HttpPost]
        public IActionResult AddProject(Project project)
        {
            //eklendi...
            return Created("http://eklendi.com", project);
        }
    }
}
