using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project_63135350.Models.Model_63135350
{
    [Table("tb_Category")]
    public class Category_63135350 : CommonAbstract_63135350
    {
        public Category_63135350()
        {
            this.News = new HashSet<News_63135350>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Tên danh mục không được để trống!")]
        [StringLength(150)]
        public string Title { get; set; }
        public string Alias { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int Position { get; set; }
        public ICollection<News_63135350> News { get; set; }
    }
}
