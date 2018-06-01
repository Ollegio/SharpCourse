using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Описание.";
            ViewBag.DateTime = DateTime.Now.ToString();

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Страница контактов.";
            ViewBag.Me = "Me :3";
            return View();
        }
    }
}