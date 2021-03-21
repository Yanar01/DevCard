using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
    public class LatestArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>
            {
                new Article(1, "title1", "description1", "blog-post-thumb-card-1.jpg"),
                new Article(2, "title2", "description2", "blog-post-thumb-card-2.jpg"),
                new Article(3, "title3", "description3", "blog-post-thumb-card-3.jpg"),
                new Article(4, "title4", "description4", "blog-post-thumb-card-4.jpg")
            };
            return View("_LatestArticles", articles);
        }
    }
}