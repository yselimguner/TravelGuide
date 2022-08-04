using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelGuide.Models.Class;

namespace TravelGuide.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context context = new Context();
        public ActionResult Index()
        {
            /*var values = context.Blogs.OrderByDescending(x=>x.BlogImage).Take(5).ToList();*///OrderByDescending'e göre yaparsak son 5 resim yapar.
            var values = context.Blogs.Take(5).ToList();
            return View(values);
        }
        public ActionResult About()
        {
            return View();
        }

        public PartialViewResult partial1()
        {
            var variables = context.Blogs.OrderByDescending(x => x.Id).Take(2).ToList();
            return PartialView(variables);
            //bunun görüntüsünü ekle ama layout alma sakın. Sadece kısmi görünüm oluştur yap.
        }

        public PartialViewResult partial2()
        {
            var variable1 = context.Blogs.Where(x => x.Id == 1).ToList();
            return PartialView(variable1);
        }

        public PartialViewResult partial3()//En iyi listeyi oluşturduk.
        {
            var variable2 = context.Blogs.Take(10).ToList();
            return PartialView(variable2);
        }

        public PartialViewResult partial4()//Our Best Places'i yapıcaz. Sağ alt tarafı.
        {
            var variable3 = context.Blogs.Take(3).ToList();
            return PartialView(variable3);
        }

        public PartialViewResult partial5()
        {
            var variable4 = context.Blogs.OrderByDescending(x => x.Id).Take(3).ToList();
            return PartialView(variable4);
        }
        
    }
}