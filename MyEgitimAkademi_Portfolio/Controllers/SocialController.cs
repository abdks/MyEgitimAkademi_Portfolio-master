using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademi_Portfolio.Models;     
namespace MyEgitimAkademi_Portfolio.Controllers
{
    public class SocialController : Controller
    {
        // GET: Social
        MyPortfolioDbEntities1 db = new MyPortfolioDbEntities1();
        public ActionResult Index()
        {
            var values = db.SocialMedia.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSocialMedia(SocialMedia SocialMedia)
        {
            db.SocialMedia.Add(SocialMedia);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteSocialMedia(int id)
        {
            var value = db.SocialMedia.Find(id);
            db.SocialMedia.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateSocialMedia(int id)
        {
            var value = db.SocialMedia.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateSocialMedia(SocialMedia SocialMedia)
        {
            var value = db.SocialMedia.Find(SocialMedia.SocialID);
            value.SocialName = SocialMedia.SocialName;
            value.SocialUrl = SocialMedia.SocialUrl;
           
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}