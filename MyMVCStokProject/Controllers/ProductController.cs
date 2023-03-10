using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyMVCStokProject.Models.Entitiy;

namespace MyMVCStokProject.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product

        private MVCDbStokEntities1 myDbStokEntities1 = new MVCDbStokEntities1();
        
        public ActionResult Index()
        {
            var myAllProducts = myDbStokEntities1.TBL_URUNLER.ToList();
            return View(myAllProducts);
        }

        [HttpGet]
        public ActionResult NewProduct()
        {
            List<SelectListItem> values = (from i in myDbStokEntities1.TBL_KATEGORILER.ToList()
                select new SelectListItem
                {
                    Text = i.KATEGORIAD,
                    Value = i.KATEGORIID.ToString()
                }).ToList();

            ViewBag.Values = values;
            return View();
        }

        [HttpPost]
        public ActionResult NewProduct(TBL_URUNLER p1)
        {
            var category = myDbStokEntities1.TBL_KATEGORILER.Where(m => m.KATEGORIID == p1.TBL_KATEGORILER.KATEGORIID)
                .FirstOrDefault();
            p1.TBL_KATEGORILER = category;
            myDbStokEntities1.TBL_URUNLER.Add(p1);
            myDbStokEntities1.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteProduct(int id)
        {
            var product = myDbStokEntities1.TBL_URUNLER.Find(id);
            myDbStokEntities1.TBL_URUNLER.Remove(product);
            myDbStokEntities1.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}