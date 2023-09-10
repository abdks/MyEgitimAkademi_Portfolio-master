using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademi_Portfolio.Models;

namespace MyEgitimAkademi_Portfolio.Controllers
{
    public class AwardController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AwardInfo()
        {
            var values = db.AwardInfo.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult UpdateAwardInfo(int id)
        {
            var value = db.AwardInfo.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateAwardInfo(AwardInfo info)
        {
            var value = db.AwardInfo.Find(info.AwardID);
            value.SubjectText = info.SubjectText;
            value.DescriptionText = info.DescriptionText;
            db.SaveChanges();
            return RedirectToAction("AwardInfo");
        }
        public ActionResult Award()
        {
            var values = db.Awards.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult UpdateAward(int id)
        {
            var value = db.Awards.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateAward(Awards award)
        {
            var value = db.Awards.Find(award.AwardID);
            value.SubjectText = award.SubjectText;
            value.DescriptionText = award.DescriptionText;
            db.SaveChanges();
            return RedirectToAction("Award");
        }
    }
}