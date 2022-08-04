using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelGuide.Models.Class;

namespace TravelGuide.Controllers
{
    public class ContactController : Controller
    {
        Context context = new Context();
        // GET: Contact
        public ActionResult Index()
        {
            var variables = context.Addresses.ToList();
            return View(variables);
        }
    }
}