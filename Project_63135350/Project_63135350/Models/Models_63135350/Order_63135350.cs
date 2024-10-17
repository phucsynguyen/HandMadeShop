using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project_63135350.Models.Model_63135350
{
    [Table("tb_Order")]
    public class Order_63135350 : CommonAbstract_63135350
    {
        public Order_63135350()
        {
            this.OrderDetails = new HashSet<OrderDetail_63135350>();
        }
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Code { get; set; }
        [Required(ErrorMessage ="Tên khách hàng không được để trống!!!")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Số điện thoại không được để trống!!!")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Địa chỉ không được để trống!!!")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Phản hồi không được để trống!!!")]
        public string Message { get; set; }
        public string Email { get; set; }
        public decimal TotalAmount { get; set; }
        public int Quanlity { get; set; }
        public int TypePayment { get; set; }
        public virtual ICollection<OrderDetail_63135350> OrderDetails { get; set; }
    }
}
