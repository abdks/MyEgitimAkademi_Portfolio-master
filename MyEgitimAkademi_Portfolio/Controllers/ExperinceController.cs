using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademi_Portfolio.Models;

namespace MyEgitimAkademi_Portfolio.Controllers
{
    public class ExperinceController : Controller
    {
        MyPortfolioDbEntities1 db = new MyPortfolioDbEntities1();
        [Authorize]
        public ActionResult Index()
        {
            var values = db.Experince.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult ExperinceAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ExperinceAdd(Experince experince)
        {
            db.Experince.Add(experince);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult ExperinceDelete(int id)
        {
            var value = db.Experince.Find(id);
            db.Experince.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult ExperinceUpdate(int id)
        {
            var value = db.Experince.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult ExperinceUpdate(Experince experince)
        {
            var value = db.Experince.Find(experince.ExperienceID);
            value.ExperinceAd = experince.ExperinceAd;
            value.ExperinceAciklama = experince.ExperinceAciklama;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}