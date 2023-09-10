using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademi_Portfolio.Models;

namespace MyEgitimAkademi_Portfolio.Controllers
{
    public class ContactInfoController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        public ActionResult Index()
        {
            var values = db.Address.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult UpdateInfo(int id)
        {
            var value = db.Address.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateInfo(Address adres)
        {
            var value = db.Address.Find(adres.AddressID);
            value.Description = adres.Description;
            value.Phone = adres.Phone;
            value.Mail = adres.AddressDetail;
            value.AddressDetail = adres.AddressDetail;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}