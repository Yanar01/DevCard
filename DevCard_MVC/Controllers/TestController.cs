using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace DevCard_MVC.Controllers
{
    public class TestController : Controller
    {
        //public ViewResult Index()
        //{
        //    return View("Footer");
        //}

        //public PartialViewResult Index()
        //{
        //    return PartialView("Footer");
        //}

        //public ContentResult Index()
        //{
        //    return Content("<h2 style='color:red;'>Hi Chetori?</h2><script>confirm('asdsa')</script>", "text/html");
        //}

        //public EmptyResult Index()
        //{
        //    //return null;
        //    return new EmptyResult();
        //}

        //public FileResult Index()
        //{
        //    return File("~/test.txt","text/html");
        //}

        //public FileResult Index()
        //{
        //    var fileByte = System.IO.File.ReadAllBytes("wwwroot/test.txt");

        //    var fileName = "testFile.txt";

        //    return File(fileByte, MediaTypeNames.Text.Plain,fileName);
        //}

        //public JsonResult Index()
        //{
        //    return Json(new { id = 1, name = "Yanar", job = "Programmer" });
        //}

        //public JavascriptResult Index()
        //{
        //    return new JavascriptResult("alert('salam, salam, salam')");
        //}

        //public RedirectResult Index()
        //{
        //    return Redirect("http://www.atriya.com");
        //}

        public StatusCodeResult Index()
        {
            //return new OkResult();
            //return  new NotFoundResult();
            //return new BadRequestResult();
            //return new NoContentResult();
            return new StatusCodeResult(888);
        }
    }

    //public class JavascriptResult : ContentResult
    //{
    //    public JavascriptResult(string data)
    //    {
    //        Content = data;
    //        ContentType = "application/javascript";
    //    }
    //}
}