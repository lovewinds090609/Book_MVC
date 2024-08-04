using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Book.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "名稱不能為空白")]
        [MaxLength(30, ErrorMessage = "名稱長度不能大於30個字元")]
        [DisplayName("書名")]
        public string Title { get; set; }
        [Required(ErrorMessage = "書名不能為空白")]
        [DisplayName("簡介")]
        public string Description { get; set; }
        [Required(ErrorMessage = "ISBN不能為空白")]
        [DisplayName("ISBN碼")]
        public string ISBN { get; set; }
        [Required(ErrorMessage = "作者不能為空白")]
        [DisplayName("作者")]
        public string Author { get; set; }
        [Range(1,10000)]
        [Required(ErrorMessage = "價格不能為空白")]
        [DisplayName("建議售價")]
        public double ListPrice { get; set; }
        [Range(1, 10000)]
        [Required(ErrorMessage = "價格不能為空白")]
        [DisplayName("購買1~50本數量的單價")]
        public double Price { get; set; }
        [Range(1, 10000)]
        [Required(ErrorMessage = "價格不能為空白")]
        [DisplayName("購買50本以上單價")]
        public double Price50 { get; set; }
        [Range(1, 10000)]
        [Required(ErrorMessage = "價格不能為空白")]
        [DisplayName("購買100本以上單價")]
        public double Price100 { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        public string ImageUrl { get; set; }
    }
}
