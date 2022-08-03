using DataAccses.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject.Controllers
{
    public class HomeController : Controller
    {
        ProjectContext db = new ProjectContext();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

    }
}