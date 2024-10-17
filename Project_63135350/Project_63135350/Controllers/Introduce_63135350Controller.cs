using Project_63135350.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_63135350.Controllers
{

    public class Introduce_63135350Controller : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Introduce_63135350
        public ActionResult Index()
        {
            return View();
        }
    }
}