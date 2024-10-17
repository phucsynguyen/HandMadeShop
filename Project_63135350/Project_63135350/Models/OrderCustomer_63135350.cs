using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project_63135350.Models
{
    public class OrderCustomer_63135350
    {
        [Required(ErrorMessage = "Tên khách hàng không được để trống!!!")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Số điện thoại không được để trống!!!")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Địa chỉ không được để trống!!!")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Lời nhắn không được để trống!!!")]
        public string Message { get; set; }
        public int TypePayment { get; set; }
    }
}