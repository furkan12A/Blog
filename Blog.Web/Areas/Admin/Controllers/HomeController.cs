using Blog.Service.Service.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly lArticleService articleService;

        public HomeController(lArticleService articleService)
        {
            this.articleService = articleService;
        }

        public async Task<IActionResult> Index()
        {
            var articles =  await articleService.GetAllArticleAsync();
            return View(articles);
        }
    }
}
