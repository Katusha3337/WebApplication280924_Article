using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication280924_Article.Models;

namespace WebApplication280924_Article.Controllers
{
    public class HomeController : Controller
    {
        private static List<Article> articles = new List<Article>
        {
            new Article { Id = 1, Title = "Статья 1", Summary = "Краткое описание статьи 1", PublishDate = DateTime.Now },
            new Article { Id = 2, Title = "Статья 2", Summary = "Краткое описание статьи 2", PublishDate = DateTime.Now.AddDays(-1) }
        };

        public IActionResult Index()
        {
            return View(articles);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Article article)
        {
            article.Id = articles.Count + 1;
            articles.Add(article);
            return RedirectToAction("Index");
        }
    }
}
