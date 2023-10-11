using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebDemo.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm=new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategoy();
            return View(values);
        }
    }
}
