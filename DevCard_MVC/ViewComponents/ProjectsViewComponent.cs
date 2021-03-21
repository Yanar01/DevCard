using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>
            {
                new Project(1, "name1", "description1", "client1","project-1.jpg"),
                new Project(2, "name2", "description2", "client2","project-2.jpg"),
                new Project(3, "name3", "description3", "client3","project-3.jpg"),
                new Project(4, "name4", "description4", "client4","project-4.jpg"),
            };
            return View("_Projects",projects);
        }
    }
}