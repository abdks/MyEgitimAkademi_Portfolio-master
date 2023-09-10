using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademi_Portfolio.Models;

namespace MyEgitimAkademi_Portfolio.Controllers
{
    public class FeatureController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        [Authorize]
        public ActionResult Index()
        {
            var values = db.Feature.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult UpdateFeature(int id)
        {
            var value = db.Feature.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateFeature(Feature feature)
        {
            var value = db.Feature.Find(feature.FeatureID);
            value.NameSurname = feature.NameSurname;
            value.Job = feature.Job;
            value.DescriptionText = feature.DescriptionText;
            value.Instagram = feature.Instagram;
            value.Linkedin = feature.Linkedin;
            value.Facebook = feature.Facebook;
            value.Twitter = feature.Twitter;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}