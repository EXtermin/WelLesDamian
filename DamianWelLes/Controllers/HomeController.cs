using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DamianWelLes.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Returns Home
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Returns About
        /// </summary>
        /// <returns></returns>
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        /// <summary>
        /// Returns Login
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {
            ViewBag.Message = "Login please";

            return View();
        }
        /// <summary>
        /// Returns Contact
        /// </summary>
        /// <returns></returns>
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page";

            return View();
        }
        public ActionResult Opdracht()
        {
            ViewBag.Message = "Your opdracht page";

            return View();
        }
        public ActionResult Extrainformatie()
        {
            ViewBag.Message = "Your extra info page";

            return View();
        }
    }
}