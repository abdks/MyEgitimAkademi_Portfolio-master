using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademi_Portfolio.Models;

namespace MyEgitimAkademi_Portfolio.Controllers
{
    public class ClientController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ClientInfo()
        {
            var value = db.ClientInfo.ToList();
            return View(value);
        }

        [HttpGet]
        public ActionResult UpdateClientInfo(int id)
        {
            var value = db.ClientInfo.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateClientInfo(ClientInfo info)
        {
            var value = db.ClientInfo.Find(info.InfoID);
            value.SubjectText = info.SubjectText;
            value.DescriptionText = info.DescriptionText;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult ClientStats()
        {
            var value = db.ClientStats.ToList();
            return View(value);
        }

        [HttpGet]
        public ActionResult AddClientStats()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddClientStats(ClientStats stats)
        {
            db.ClientStats.Add(stats);
            db.SaveChanges();
            return RedirectToAction("ClientStats");
        }

        [HttpGet]
        public ActionResult UpdateClientStats(int id)
        {
            var value = db.ClientStats.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateClientStats(ClientStats stats)
        {
            var value = db.ClientStats.Find(stats.StatsID);
            value.SubjectText = stats.SubjectText;
            value.DescriptionText = stats.DescriptionText;
            value.StatsValue = stats.StatsValue;
            db.SaveChanges();
            return RedirectToAction("ClientStats");
        }
        public ActionResult DeleteClientStats(int id)
        {
            var value = db.ClientStats.Find(id);
            db.ClientStats.Remove(value);
            db.SaveChanges();
            return RedirectToAction("ClientStats");
        }


        public ActionResult Client()
        {
            var value = db.Clients.ToList();
            return View(value);
        }

        [HttpGet]
        public ActionResult AddClient()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddClient(Clients client)
        {
            db.Clients.Add(client);
            db.SaveChanges();
            return RedirectToAction("Client");
        }

        [HttpGet]
        public ActionResult UpdateClient(int id)
        {
            var value = db.Clients.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateClient(Clients client)
        {
            var value = db.Clients.Find(client.ClientID);
            value.ImgUrl = client.ImgUrl;
            db.SaveChanges();
            return RedirectToAction("Client");
        }
        public ActionResult DeleteClient(int id)
        {
            var value = db.Clients.Find(id);
            db.Clients.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Client");
        }


    }
}