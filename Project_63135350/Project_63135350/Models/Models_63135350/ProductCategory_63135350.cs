using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project_63135350.Models.Model_63135350
{
    [Table("tb_ProductCategory")]
    public class ProductCategory_63135350 : CommonAbstract_63135350
    {
        public ProductCategory_63135350()
        {
            this.Products = new HashSet<Product_63135350>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]    
        public string Title { get; set; }
        [Required]
        [StringLength(150)]
        public string Alias { get; set; }
        public string Description { get; set; }
        [StringLength(250)]
        public string Icon { get; set; }       

        public ICollection<Product_63135350> Products { get; set; }
    }
}
