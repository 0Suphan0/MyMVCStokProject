﻿using System;
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
    }
}