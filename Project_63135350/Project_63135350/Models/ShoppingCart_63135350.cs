using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_63135350.Models
{
    public class ShoppingCart_63135350
    {
        public List<ShoppingCartItem> Items { get; set; }
        public ShoppingCart_63135350()
        {
            this.Items = new List<ShoppingCartItem>();
        }
        public void AddtoCart(ShoppingCartItem item, int Quanlity)
        {
            var checkExits = Items.FirstOrDefault(x => x.ProductId == item.ProductId);
            if (checkExits != null)
            {
                checkExits.Quanlity += Quanlity;
                checkExits.TotalPrice = checkExits.Price * checkExits.Quanlity;
            }
            else
            {
                Items.Add(item);
            }
        }
        public void Remove(int id)
        {
            var checkExits = Items.SingleOrDefault(x => x.ProductId == id);
            if (checkExits != null)
            {
                Items.Remove(checkExits);
            }
        }
        public void UpdateQuanlity(int id, int quanlity)
        {
            var checkExits = Items.SingleOrDefault(x => x.ProductId == id);
            if (checkExits != null)
            {
                checkExits.Quanlity = quanlity;
                checkExits.TotalPrice = checkExits.Price * checkExits.Quanlity;
            }
        }
        public decimal GetTotalPrice()
        {
            return Items.Sum(x => x.TotalPrice);
        }
        public int GetTotalQuanlity()
        {
            return Items.Sum(x => x.Quanlity);
        }
        public void ClearCart()
        {
            Items.Clear();
        }
    }
    public class ShoppingCartItem
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Alias { get; set; }
        public string CategoryName { get; set; }
        public string ProductImg { get; set; }
        public int Quanlity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }

    }
}