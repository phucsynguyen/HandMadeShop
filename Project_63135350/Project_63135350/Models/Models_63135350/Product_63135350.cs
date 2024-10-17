using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_63135350.Models.Model_63135350
{
    [Table("tb_Product")]
    public class Product_63135350 : CommonAbstract_63135350
    {
        public Product_63135350()
        {
            this.ProductImage = new HashSet<ProductImage_63135350>();
            this.OrderDetails = new HashSet<OrderDetail_63135350>();
        }

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(250)]
        public string Title { get; set; }
        public string Alias { get; set; }
        [StringLength(50)]
        public string ProductCode { get; set; }
        public string Description { get; set; }
        [AllowHtml]
        public string Detail { get; set; }
        [StringLength(250)]
        public string Image { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal Price { get; set; }
        public decimal? PriceSale { get; set; }
        public int Quanlity { get; set; }
        public bool IsHome { get; set; }
        public bool IsSale { get; set; }
        public bool IsFeature { get; set; }
        public bool IsHot { get; set; }
        public bool IsActive { get; set; }
        public int ProductCategoryID { get; set; }
        public virtual ProductCategory_63135350 ProductCategory { get; set; }
        public virtual ICollection<ProductImage_63135350> ProductImage { get; set; }
        public virtual ICollection<OrderDetail_63135350> OrderDetails { get; set; }
    }
}
