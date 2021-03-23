using System;
using System.Collections.Generic;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Service> _services = new()
        {
            new Service(1, "سطح ۱"),
            new Service(2, "سطح ۲"),
            new Service(3, "سطح ۳"),
            new Service(4, "سطح ۴")
        };

        public HomeController(ILogger<HomeController> logger)
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact()
            {
                Services = new SelectList(_services, "Id", "Name")
            };
            return View(model);
        }

        //[HttpPost]
        //public JsonResult Contact(IFormCollection form)
        //{
        //    var name = form["name"].ToString();
        //    return Json(Ok());
        //}

        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            model.Services = new SelectList(_services, "Id", "Name");
            if (!ModelState.IsValid)
            {
                ViewData["error"] = "اطلاعات وارد شده صحیح نمی‌باشد";
                return View(model);
            }

            ModelState.Clear();
            model = new Contact()
            {
                Services = new SelectList(_services, "Id", "Name")
            };
            ViewData["success"] = "پیغام شما با موفقیت ثبت شد";
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}