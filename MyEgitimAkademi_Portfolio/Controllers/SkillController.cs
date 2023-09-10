using MyEgitimAkademi_Portfolio.Models;
using System.Linq;
using System.Web.Mvc;

namespace MyEgitimAkademi_Portfolio.Controllers
{
    [Authorize]

    public class SkillController : Controller
    {
        MyPortfolioDbEntities1 db = new MyPortfolioDbEntities1();

        public ActionResult Index()
        {
            var values = db.Skill2.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult SkillAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SkillAdd(Skill2 testskill)
        {
            db.Skill2.Add(testskill);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult SkillDelete(int id)
        {
            var value = db.Skill2.Find(id);
            db.Skill2.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult SkillUpdate(int id)
        {
            var value = db.Skill2.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult SkillUpdate(Skill2 Skill2)
        {
            var value = db.Skill2.Find(Skill2.SkillID);
            value.SkillTitle = Skill2.SkillTitle;
            value.SkillValue = Skill2.SkillValue;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}