using Project_63135350.Models;
using Project_63135350.Models.Model_63135350;
using Project_63135350.Models.Models_63135350;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_63135350.Controllers
{
    public class Product_63135350Controller : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Product_63135350
        public ActionResult Index()
        {
            var items = db.Products.ToList();           
            return View(items);
        }
        public ActionResult Detail(string alias, int id)
        {
            var item = db.Products.Find(id);           
            return View(item);
        }
        public ActionResult ProductCategory(string alias,int id)
        {
            var items = db.Products.ToList();
            if (id > 0)
            {
                items = items.Where(x => x.ProductCategoryID == id).ToList();
            }
            var cate = db.ProductCategories.Find(id);
            if(cate != null)
            {
                ViewBag.CateName = cate.Title;
            }
            ViewBag.CateId = id;
            return View(items);
        }
        public ActionResult Partial_ItemsByCateId()
        {
            var items = db.Products.Where(x =>x.IsActive).ToList();
            return PartialView(items);
        }
        public ActionResult Partial_SaleProduct()
        {
            var items = db.Products.Where(x => x.IsSale && x.IsActive).ToList();
            return PartialView(items);
        }
        public ActionResult PhanHoi_ThanhCong()
        {
            return View();
        }
        public ActionResult Product_Sale()
        {
            var items = db.Products.Where(x => x.IsSale && x.IsActive).ToList();
            return PartialView(items);
        }
        public ActionResult Service()
        {
            return View();
        }
        public ActionResult Partial_PhanHoi()
        {
            return PartialView();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Service(OrderCustomer_63135350 req)
        {
            var code = new { Success = false, Code = -1 };
            if (ModelState.IsValid)
            {
                CustomerInfo customer = new CustomerInfo
                {
                    CustomerName = req.CustomerName,
                    Phone = req.Phone,
                    Address = req.Address,
                    Message = req.Message,  
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                };
                db.CustomerInfo.Add(customer);
                db.SaveChanges();

                return RedirectToAction("PhanHoi_ThanhCong");
            }
            return Json(code);
        }
    }
}