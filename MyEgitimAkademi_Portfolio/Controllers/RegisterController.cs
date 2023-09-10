
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademi_Portfolio.Models;
namespace MyEgitimAkademi_Portfolio.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        MyPortfolioDbEntities1 db = new MyPortfolioDbEntities1();

       

        [HttpGet]
        public ActionResult AdminAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminAdd(AdminTable Admintable)
        {
            db.AdminTable.Add(Admintable);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}