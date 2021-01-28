using MyFirstWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstWebApp.Controllers
{
    public class TestController : Controller
    {
        public ActionResult Contact()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Download(int? id)
        {
            ViewBag.PluginId = id;
            return View();
        }

        [HttpPost]
        public string Download(Purchase pur)
        {
            pur.Date = DateTime.Now;
            HomeController.db.Purchases.Add(pur);
            HomeController.db.SaveChanges();
            return $"{pur.Name}, спасибо за покупку!";
        }

        public string GetId()
        {
            int id = Int32.Parse(Request.Params["id"]);
            return id.ToString();
        }

    }
}