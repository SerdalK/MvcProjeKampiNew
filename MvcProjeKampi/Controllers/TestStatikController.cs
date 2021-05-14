using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class TestStatikController : Controller
    {
        public ActionResult Index()
        {
            Context c = new Context();
            var deger1 = c.Categories.Count();
            ViewBag.d1 = deger1;

            var hid = c.Categories.Where(x => x.CategoryName == "Yazılım").Select(y => y.CategoryID).FirstOrDefault();
            var deger2 = c.Headings.Where(x => x.CategoryID == hid).Count();
            ViewBag.d2 = deger2;

            var deger3 = c.Writers.Count(x => x.WriterName.Contains("a"));
            ViewBag.d3 = deger3;

            var deger4 = c.Categories.Where(x => x.CategoryID == c.Headings.GroupBy(y => y.CategoryID).OrderByDescending(z => z.Count()).Select(t => t.Key).FirstOrDefault()).Select(k => k.CategoryName).FirstOrDefault();
            ViewBag.d4 = deger4;

            var deger5 = c.Categories.Where(x => x.CategoryStatus == true).Count() - c.Categories.Where(x => x.CategoryStatus == false).Count();
            ViewBag.d5 = deger5;

            return View();
        }

    }
}