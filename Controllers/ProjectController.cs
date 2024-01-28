using ICE_01.Models;
using Microsoft.AspNetCore.Mvc;

namespace ICE_01.Controllers
{
    public class ProjectController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var projects = new List<Project>()
            {
                new Project{ProjectId = 1, Name = "Project 1", Description = "MVC Project based on ASP.NET" },
                new Project{ProjectId = 2, Name = "Project 2", Description = "DSA Project" },
                new Project{ProjectId = 3, Name = "Project 3", Description = "Python Project" }

            };
            if (projects == null)
            {
                return NotFound(); // or handle the case where the project is not found
            }

            return View(projects);
           

        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var projects = new Project { ProjectId = 1, Name = "Project 1", Description = "MVC Project based on ASP.NET" };
            return View(projects);
        }


        [HttpPost]
        public IActionResult Create(Project project)
        {
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }
}
