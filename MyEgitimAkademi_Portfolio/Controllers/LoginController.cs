using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademi_Portfolio.Models;
using System.Web.Security;
namespace MyEgitimAkademi_Portfolio.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        MyPortfolioDbEntities1 db = new MyPortfolioDbEntities1();

        public ActionResult login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(AdminTable adminTable)
        {
            var bilgiler = db.AdminTable.FirstOrDefault(x => x.Adminname == adminTable.Adminname && x.Adminpassword == adminTable.Adminpassword);
            if(bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.Adminname,false);
                Session["Adminname"] = bilgiler.Adminname.ToString();
                return RedirectToAction("Index", "Testimonial");
            }
            else
            {
                return View();
            }

        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Login");
        }
    }
}