using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TheJammer.Models;

namespace TheJammer.Controllers
{

    public class HomeController : Controller
    {
        private TheJammerContext db = new TheJammerContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View(db.Comments.ToList());
        }


    }
}