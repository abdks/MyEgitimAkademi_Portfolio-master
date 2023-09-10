using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademi_Portfolio.Models;

namespace MyEgitimAkademi_Portfolio.Controllers
{
    public class MessageBoxController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        public ActionResult Index()
        {
            var values = db.Contact.ToList();
            return View(values);
        }

        public ActionResult DeleteMessage(int id)
        {
            var value = db.Contact.Find(id);
            db.Contact.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}