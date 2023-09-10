using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademi_Portfolio.Models;

namespace MyEgitimAkademi_Portfolio.Controllers
{
    public class LanguageController : Controller
    {
        MyPortfolioDbEntities1 db = new MyPortfolioDbEntities1();

        public ActionResult Index()
        {
            var values = db.Language.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddLanguage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddLanguage(Language Language)
        {
            db.Language.Add(Language);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteLanguage(int id)
        {
            var value = db.Language.Find(id);
            db.Language.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateLanguage(int id)
        {
            var value = db.Language.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateLanguage(Language Language)
        {
            var value = db.Language.Find(Language.LanguageID);
            value.LangueUrl = Language.LangueUrl;
            
            db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
