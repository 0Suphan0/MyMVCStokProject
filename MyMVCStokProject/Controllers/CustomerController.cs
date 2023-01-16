﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyMVCStokProject.Models.Entitiy;

namespace MyMVCStokProject.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer

        private MVCDbStokEntities1 mvcDbStokEntities1 = new MVCDbStokEntities1();
        public ActionResult Index()
        {
            var myAllCustomers = mvcDbStokEntities1.TBL_MUSTERILER.ToList();
            return View(myAllCustomers);
        }

        [HttpGet]
        public ActionResult NewCustomer()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult NewCustomer(TBL_MUSTERILER p1)
        {
            mvcDbStokEntities1.TBL_MUSTERILER.Add(p1);
            mvcDbStokEntities1.SaveChanges();
            return View();
        }
    }
}