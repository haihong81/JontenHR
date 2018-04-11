using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JontenHR.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "中天运会计师事务所简介";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "联系我们：联系方式";

            return View();
        }
    }
}