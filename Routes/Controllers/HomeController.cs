using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Routes.Models;

namespace Routes.Controllers
{
    public class HomeController : Controller
    {
        //Notice from Models > Notice.cs
        private readonly IEnumerable<Notice> allNotices;

        //constructor
        public HomeController()
        {
            //order by descending date (x=>x.Date)
            allNotices = new Notice().AllNotices().OrderByDescending(x=>x.Date);
        }

        public ActionResult Index()
        {
            //last 3 notices
            var lastNotices = allNotices.Take(3);
            //all categories distinct
            var allCategories = allNotices.Select(x=>x.Category).Distinct().ToList();
            ViewBag.Categories = allCategories;
            //return last notices typed view
            return View(lastNotices);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}