using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            //var liste = blogManager.GetAllBlogs();
            var liste = blogManager.GetBlogListWithCategory();
            return View(liste);
        }
        public IActionResult BlogReadAll(int id) 
        {
            var values=blogManager.GetBlogById(id);
            return View(values);
        }
    }
}
