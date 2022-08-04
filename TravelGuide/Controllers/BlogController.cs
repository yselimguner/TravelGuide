using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelGuide.Models.Class;

namespace TravelGuide.Controllers
{
    public class BlogController : Controller
    {
        Context context = new Context();
        // GET: Blog
        BlogComment bc = new BlogComment();
        public ActionResult Index()
        {
            bc.value1 = context.Blogs.ToList();
            bc.value3 = context.Blogs.Take(3);
            bc.value4 = context.Comments.Take(3);
            return View(bc);
        }
       

        public ActionResult BlogDetails(int id)
        {
            //var findBlog = context.Blogs.Where(x => x.Id == id).ToList();
            bc.value1 = context.Blogs.Where(x => x.Id == id).ToList();
            bc.value2 = context.Comments.Where(x => x.BlogId == id).ToList();
            return View(bc);
        }
        [HttpGet]
        public PartialViewResult Comment(int id)
        {
            ViewBag.value1 = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult Comment(Comments comments)
        {
            context.Comments.Add(comments);
            context.SaveChanges();
            return PartialView();
        }
    }
}