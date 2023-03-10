using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyMVCStokProject.Models.Entitiy;

namespace MyMVCStokProject.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category

        private MVCDbStokEntities1 _mvcDbStokEntities1 = new MVCDbStokEntities1();
        public ActionResult Index()
        {
            var allCategories = _mvcDbStokEntities1.TBL_KATEGORILER.ToList();

            return View(allCategories);
        }

        [HttpGet]
        public ActionResult NewCategory()
        {

            return View();
        }

        [HttpPost]
        public ActionResult NewCategory(TBL_KATEGORILER p1)
        {
            _mvcDbStokEntities1.TBL_KATEGORILER.Add(p1);
            _mvcDbStokEntities1.SaveChanges();
            return View();
        }


        public ActionResult DeleteCategory(int id)
        {
            var category = _mvcDbStokEntities1.TBL_KATEGORILER.Find(id);
            _mvcDbStokEntities1.TBL_KATEGORILER.Remove(category);
            _mvcDbStokEntities1.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult GetCategory(int id)
        {
            var category = _mvcDbStokEntities1.TBL_KATEGORILER.Find(id);

            return View("GetCategory", category);

        }
    }
}