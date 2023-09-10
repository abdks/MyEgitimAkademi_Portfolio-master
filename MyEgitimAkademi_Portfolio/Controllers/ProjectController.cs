using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademi_Portfolio.Models;

namespace MyEgitimAkademi_Portfolio.Controllers
{
    [Authorize]

    public class ProjectController : Controller
    {

        MyPortfolioDbEntities1 db = new MyPortfolioDbEntities1();
        public ActionResult Index()
        {
            var values = db.Project.ToList();
            return View(values);//buraya sonradan values gelecek
        }
    }
}