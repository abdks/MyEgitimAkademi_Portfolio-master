using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademi_Portfolio.Models;
namespace MyEgitimAkademi_Portfolio.Controllers
{
    public class ContactController : Controller
    {
        MyPortfolioDbEntities1 db = new MyPortfolioDbEntities1();

        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.description = db.Adress.Select(x => x.Description).FirstOrDefault();
            ViewBag.phone = db.Adress.Select(x => x.Phone).FirstOrDefault();
            ViewBag.mail = db.Adress.Select(x => x.Mail).FirstOrDefault();
            ViewBag.addressDetail = db.Adress.Select(x => x.AddressDetail).FirstOrDefault();
            return View();
        }

        [HttpPost]
        public ActionResult Index(Contact contact)
        {
            db.Contact.Add(contact);
            db.SaveChanges();
            return RedirectToAction("Index", "Default");
        }
        public PartialViewResult PartialScript()
        {
            // Kısmi görünümün adını veya yolunu belirtmelisiniz.
            // Örnek olarak, "PartialScript" adlı bir kısmi görünümünüz olduğunu varsayalım.
            return PartialView("PartialScript");
        }


    }
}