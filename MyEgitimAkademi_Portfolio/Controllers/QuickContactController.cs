using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademi_Portfolio.Models;

namespace MyEgitimAkademi_Portfolio.Controllers
{
    public class QuickContactController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        [Authorize]
        public ActionResult Index()
        {
            var values = db.QuickContact.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult UpdateQuickContact(int id)
        {
            var value = db.QuickContact.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateQuickContact(QuickContact contact)
        {
            var value = db.QuickContact.Find(contact.ContactID);
            value.NameSurname = contact.NameSurname;
            value.DescriptionText = contact.DescriptionText;
            value.Phone = contact.Phone;
            value.Email = contact.Email;
            value.Instagram = contact.Instagram;
            value.Linkedin = contact.Linkedin;
            value.Facebook = contact.Facebook;
            value.Twitter = contact.Twitter;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}