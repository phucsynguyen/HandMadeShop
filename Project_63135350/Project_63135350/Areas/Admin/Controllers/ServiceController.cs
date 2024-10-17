using Project_63135350.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_63135350.Areas.Admin.Controllers
{
    public class ServiceController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/Service
        public ActionResult Index()
        {
            var customers = db.CustomerInfo.ToList();
            return View(customers);
        }
    }
}