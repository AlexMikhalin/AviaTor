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
        public ActionResult Index()
        {
            IEnumerable<Value> values = db.Values;
            ViewBag.Values = values;
            return View();
        }

       
    }
}