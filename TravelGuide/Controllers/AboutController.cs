using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelGuide.Models.Class;

namespace TravelGuide.Controllers
{
    public class AboutController : Controller
    {
        // GET: About

        Context context = new Context();

        public ActionResult Index()
        {
            var writeUs = context.AboutUses.ToList();
            return View(writeUs);
        }
        public PartialViewResult SocialMedia()
        {
            var variables = context.SocialMedias.ToList();
            return PartialView(variables);
        }

        public PartialViewResult Skills()
        {
            var variables1 = context.Skills.ToList();
            return PartialView(variables1);
        }
    }
}