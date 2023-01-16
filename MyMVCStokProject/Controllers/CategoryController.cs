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
    }
}