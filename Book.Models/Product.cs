using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "名稱不能為空白")]
        [MaxLength(30, ErrorMessage = "名稱長度不能大於30個字元")]
        [DisplayName("Title")]
        public string Title { get; set; }
    }
}
