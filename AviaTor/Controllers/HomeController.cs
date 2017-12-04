using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AviaTor.Models;

namespace AviaTor.Controllers
{
    public class HomeController : Controller
    {
        ValContext db = new ValContext();
        KlienContext kdb = new KlienContext();
        public ActionResult Index()
        {
            
            IEnumerable<Value> values = db.Values;
            ViewBag.Values = values;
            IEnumerable < Klients> clien = kdb.Clienti;
            ViewBag.Clienti = clien;
            return View();
        }


       
    }
}