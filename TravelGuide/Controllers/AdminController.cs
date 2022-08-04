using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelGuide.Models.Class;

namespace TravelGuide.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context context = new Context(); 
        [Authorize]
        public ActionResult Index()
        {
            var variables = context.Blogs.ToList();
            return View(variables);
        }

        //Sayfa yüklendiği zaman çalışsın diye HttpGet'te çalışsın istedik.
        [Authorize]
        [HttpGet]
        public ActionResult NewBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewBlog(Blog b)
        {
            context.Blogs.Add(b);//Bunu yazarak NewBlog sayfsında yaptığımız değerleri b'ye atarız.
            context.SaveChanges();
            return RedirectToAction("Index"); //Yönlendirmek için bu işlemi yaparız.
        }

        public ActionResult DeleteBlog(int id)
        {
            var blogg = context.Blogs.Find(id);
            context.Blogs.Remove(blogg);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult GetBlog(int id)//GÜNCELLEME 36'NCI DERSTE.
        {
            var blogg1 = context.Blogs.Find(id);
            return View("GetBlog", blogg1);
        }

        public ActionResult UpdateBlog(Blog blogg2)
        {
            var blg = context.Blogs.Find(blogg2.Id);
            blg.Description = blogg2.Description;
            blg.Title = blogg2.Title;
            blg.Date = blogg2.Date;
            blg.BlogImage = blogg2.BlogImage;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize]
        public ActionResult ListofComments()
        {
            var comments = context.Comments.ToList();
            return View(comments);
        }

        public ActionResult DeleteComment(int id)
        {
            var commentt = context.Comments.Find(id);
            context.Comments.Remove(commentt);
            context.SaveChanges();
            return RedirectToAction("ListofComments");
        }
        [Authorize]
        public ActionResult GetComments(int id)//GÜNCELLEME 36'NCI DERSTE.
        {
            var comment1 = context.Comments.Find(id);
            return View("GetComments", comment1);
        }

        public ActionResult UpdateComments(Comments comment2)
        {
            var cmmnt = context.Comments.Find(comment2.Id);
            cmmnt.UserName = comment2.UserName;
            cmmnt.Comment = comment2.Comment;
            cmmnt.Mail = comment2.Mail;
            context.SaveChanges();
            return RedirectToAction("ListofComments");
        }


        //About Bölümü için
        public ActionResult About()
        {
            var variables = context.AboutUses.ToList();
            return View(variables);
        }


        public ActionResult GetAbout(int id)//GÜNCELLEME 36'NCI DERSTE.
        {
            var about = context.AboutUses.Find(id);
            return View("GetAbout", about);
        }

        public ActionResult UpdateAbout(AboutUs about2)
        {
            var abt = context.AboutUses.Find(about2.Id);
            abt.Description = about2.Description;
            abt.Name = about2.Name;
            abt.PhotoUrl = about2.PhotoUrl;
            context.SaveChanges();
            return RedirectToAction("About");
        }

        //Social Media Bölümü için

        public ActionResult SocialMedia()
        {
            var variables = context.SocialMedias.ToList();
            return View(variables);
        }

        //Sayfa yüklendiği zaman çalışsın diye HttpGet'te çalışsın istedik.
        [HttpGet]
        public ActionResult AddSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSocialMedia(SocialMedia sm)
        {
            context.SocialMedias.Add(sm);
            context.SaveChanges();
            return RedirectToAction("SocialMedia"); 
        }

        public ActionResult DeleteSocialMedia(int id)
        {
            var sm = context.SocialMedias.Find(id);
            context.SocialMedias.Remove(sm);
            context.SaveChanges();
            return RedirectToAction("SocialMedia");
        }

        public ActionResult GetSocialMedia(int id)//GÜNCELLEME 36'NCI DERSTE.
        {
            var sm = context.SocialMedias.Find(id);
            return View("GetSocialMedia", sm);
        }

        public ActionResult UpdateSocialMedia(SocialMedia sm2)
        {
            var smm = context.SocialMedias.Find(sm2.Id);
            smm.Brand = sm2.Brand;
            smm.Icon = sm2.Icon;
            smm.Link = sm2.Link;
            context.SaveChanges();
            return RedirectToAction("SocialMedia");
        }

        //Skills bölümü için
        public ActionResult Skills()
        {
            var variables = context.Skills.ToList();
            return View(variables);
        }

        [HttpGet]
        public ActionResult AddSkill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSkill(Skills sk)
        {
            context.Skills.Add(sk);
            context.SaveChanges();
            return RedirectToAction("Skills");
        }

        public ActionResult DeleteSkill(int id)
        {
            var sk = context.Skills.Find(id);
            context.Skills.Remove(sk);
            context.SaveChanges();
            return RedirectToAction("Skills");
        }
        public ActionResult GetSkill(int id)//GÜNCELLEME 36'NCI DERSTE.
        {
            var sk = context.Skills.Find(id);
            return View("GetSkill", sk);
        }
        public ActionResult UpdateSkill(Skills sk2)
        {
            var sk = context.Skills.Find(sk2.Id);
            sk.Name = sk2.Name;
            sk.Percentage = sk2.Percentage;
            context.SaveChanges();
            return RedirectToAction("Skills");
        }

        //Contact Bölümü
        public ActionResult Communicate()
        {
            var variables = context.Addresses.ToList();
            return View(variables);
        }


        public ActionResult GetCommunicate(int id)//GÜNCELLEME 36'NCI DERSTE.
        {
            var ad = context.Addresses.Find(id);
            return View("GetCommunicate", ad);
        }
        public ActionResult UpdateCommunicate(Address ad2)
        {
            var ad = context.Addresses.Find(ad2.Id);
            ad.Location = ad2.Location;
            ad.Mail = ad2.Mail;
            ad.PhoneNumber = ad2.PhoneNumber;
            ad.Title = ad2.Title;
            ad.AddressWrite = ad2.AddressWrite;
            ad.Description = ad2.Description;
            context.SaveChanges();
            return RedirectToAction("Communicate");
        }
        
        

    }
}