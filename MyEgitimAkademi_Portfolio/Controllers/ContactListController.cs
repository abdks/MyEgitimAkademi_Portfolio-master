using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademi_Portfolio.Models;
namespace MyEgitimAkademi_Portfolio.Controllers
{
    public class ContactListController : Controller
    {
        // GET: ContactList
        MyPortfolioDbEntities1 db = new MyPortfolioDbEntities1();

        [Authorize]


        public ActionResult Index()
        {
            var values = db.Contact.ToList();
            return View(values);
        }
        //[HttpGet]
      
        //[HttpPost]
        //public PartialViewResult PartialCommunication(Contact communication2)
        //{
        //    db.Contact.Add(communication2);
        //    db.SaveChanges();
        //    return PartialView();
        //}
        public ActionResult DeleteCommunication(int id)
        {
            var value = db.Contact.Find(id);
            db.Contact.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }





    }
}