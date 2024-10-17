using PagedList;
using Project_63135350.Models;
using Project_63135350.Models.Model_63135350;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace Project_63135350.Controllers
{

    public class TinTuc_63135350Controller : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: TinTuc_63135350
        public ActionResult Index(int? page)
        {
            var pageSize = 5;
            if (page == null)
            {
                page = 1;
            }
            IEnumerable<News_63135350> items = db.News.OrderByDescending(x => x.CreatedDate);
            var pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;
            items = items.ToPagedList(pageIndex, pageSize);
            ViewBag.PageSize = pageSize;
            ViewBag.Page = page;
            return View(items);
        }
        public ActionResult Detail(int id)
        {
            var item = db.News.Find(id);
            return View(item);
        }
        public ActionResult Partial_TinTuc()
        {
            var items = db.News.Take(3).ToList();
            return PartialView(items);
        }
    }
}